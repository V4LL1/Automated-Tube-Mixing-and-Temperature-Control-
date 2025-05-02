using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace tube_mixing_software
{
    public partial class Registar : Form
    {
        public Registar()
        {
            InitializeComponent();
        }


        private void Registar_Load(object sender, EventArgs e)
        {
            try
            {
                var conn = Conexao.ObterConexao();
                string query = "SELECT idcargos, nome FROM cargos";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    Dictionary<int, string> cargos = new Dictionary<int, string>();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32("idcargos");
                        string nome = reader.GetString("nome");
                        cargos.Add(id, nome);
                    }

                    cargoTxt.DataSource = new BindingSource(cargos, null);
                    cargoTxt.DisplayMember = "Value"; // o que aparece na lista
                    cargoTxt.ValueMember = "Key";     // o que usamos no código
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar cargos: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

        private void registarBtn_Click(object sender, EventArgs e)
        {
            // Verificação da senha administrativa
            if (senhaAdminTxt.Text != "admin123")
            {
                MessageBox.Show("Senha administrativa incorreta. Ação não permitida.");
                return;
            }

            string nome = nomeTxt.Text;
            string email = emailTxt.Text;
            string senha = senhaTxt.Text;
            int cargoId = ((KeyValuePair<int, string>)cargoTxt.SelectedItem).Key;

            try
            {
                var conn = Conexao.ObterConexao();

                string queryInsert = "INSERT INTO Funcionario (nome, email, senha, cargos_idcargos) " +
                                     "VALUES (@nome, @email, @senha, @cargoId)";

                using (MySqlCommand cmdInsert = new MySqlCommand(queryInsert, conn))
                {
                    cmdInsert.Parameters.AddWithValue("@nome", nome);
                    cmdInsert.Parameters.AddWithValue("@email", email);
                    cmdInsert.Parameters.AddWithValue("@senha", senha);
                    cmdInsert.Parameters.AddWithValue("@cargoId", cargoId);

                    int linhasAfetadas = cmdInsert.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        MessageBox.Show("Funcionário registrado com sucesso!");
                        nomeTxt.Clear();
                        emailTxt.Clear();
                        senhaTxt.Clear();
                        senhaAdminTxt.Clear();
                        cargoTxt.SelectedIndex = 0;
                    }
                    else
                    {
                        MessageBox.Show("Erro ao registrar funcionário.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }

    }
}
