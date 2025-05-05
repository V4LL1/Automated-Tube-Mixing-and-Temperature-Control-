using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using MySql.Data.MySqlClient;

namespace tube_mixing_software
{
    public partial class Iniciar : Form
    {

        private int idFuncionario;

        public Iniciar(int funcionarioId)
        {
            InitializeComponent();
            idFuncionario = funcionarioId;
            tempLbl.Text = SerialManager.UltimaTemperatura;

        }


        private void iniciarBtn_Click(object sender, EventArgs e)
        {

            // Verifica se a temperatura atual está disponível
            if (string.IsNullOrWhiteSpace(SerialManager.UltimaTemperatura))
            {
                MessageBox.Show("Temperatura atual não disponível ainda.");
                return;
            }

            // Tenta converter a temperatura atual
            if (!double.TryParse(SerialManager.UltimaTemperatura.Replace(".", ","), out double tempAtual))
            {
                MessageBox.Show("Falha ao interpretar a temperatura atual.");
                return;
            }

            // Tenta converter a temperatura desejada digitada pelo usuário
            if (!double.TryParse(txtTemp.Text.Replace(".", ","), out double tempDesejada))
            {
                MessageBox.Show("O valor de temperatura inserido é inválido.");
                return;
            }

            // Compara as temperaturas e envia o comando adequado
            if (tempAtual < tempDesejada)
            {
                EnviarComando("ON1:10"); // Liga relé 1 por 10 segundos
                MessageBox.Show($"Temperatura atual ({tempAtual}°C) < desejada ({tempDesejada}°C). Ligando RELÉ 1.");
            }
            else if (tempAtual > tempDesejada)
            {
                EnviarComando("ON2:10"); // Liga relé 2 por 10 segundos
                MessageBox.Show($"Temperatura atual ({tempAtual}°C) > desejada ({tempDesejada}°C). Ligando RELÉ 2.");
            }
            else
            {
                MessageBox.Show("Temperatura atual igual à desejada. Nenhum relé foi acionado.");
            }

            // Verifica se o tempo está válido
            if (!int.TryParse(tempoTxt.Text.Trim(), out int tempoMotor) || tempoMotor <= 0)
            {
                MessageBox.Show("O tempo inserido para o motor é inválido.");
                return;
            }

            // Envia comando para motor de passo
            EnviarComando("MOTOR:" + tempoMotor);
            MessageBox.Show($"Motor de passo acionado por {tempoMotor} segundos.");


            int idFrasco = 0;
            int idPaciente = 0;

            if (comboFrascos.SelectedItem is DataRowView row)
            {
                idFrasco = Convert.ToInt32(row["idFrasco"]);
                idPaciente = Convert.ToInt32(row["Paciente_idPaciente"]);
            }
            else
            {
                MessageBox.Show("Erro ao extrair os dados do frasco.");
                return;
            }

            // Inserir no banco de dados

            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    string query = @"INSERT INTO Mistura 
                            (temperatura, tempo, Funcionario_idFuncionario, Frasco_idFrasco, Frasco_Paciente_idPaciente) 
                            VALUES (@temperatura, @tempo, @funcionario, @frasco, @paciente);";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@temperatura", tempDesejada);
                        cmd.Parameters.AddWithValue("@tempo", tempoMotor);
                        cmd.Parameters.AddWithValue("@funcionario", idFuncionario);
                        cmd.Parameters.AddWithValue("@frasco", idFrasco);
                        cmd.Parameters.AddWithValue("@paciente", idPaciente);

                        cmd.ExecuteNonQuery();
                    }

                    //Conexao.FecharConexao();
                }

                MessageBox.Show("Mistura registrada com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar no banco de dados: " + ex.Message);
            }


        }

        private void EnviarComando(string comando)
        {
            if (SerialManager.Port != null && SerialManager.Port.IsOpen)
            {
                SerialManager.Port.WriteLine(comando);
                //txtLog.AppendText("Enviado: " + comando + "\r\n");
            }
            else
            {
                MessageBox.Show("Porta serial não conectada.");
            }
        }
        private void Iniciar_Load(object sender, EventArgs e)
        {
            CarregarFrascos();
        }

        private void CarregarFrascos()
        {
            try
            {
                using (var conn = Conexao.ObterConexao())
                {
                    string query = @"SELECT idFrasco, Paciente_idPaciente, 
                             CONCAT('Frasco ', idFrasco, ' (Paciente ', Paciente_idPaciente, ')') AS Descricao 
                             FROM Frasco";

                    using (var adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        comboFrascos.DisplayMember = "Descricao";
                        comboFrascos.ValueMember = "idFrasco"; // não é obrigatório usar, mas ajuda
                        comboFrascos.DataSource = dt;
                    }

                    Conexao.FecharConexao();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar frascos: " + ex.Message);
            }
        }

        public class FrascoComboItem
        {
            public int IdFrasco { get; set; }
            public int IdPaciente { get; set; }
            public string NomePaciente { get; set; }

            public override string ToString()
            {
                return $"Frasco #{IdFrasco} - Paciente: {NomePaciente}";
            }
        }
    }
}
