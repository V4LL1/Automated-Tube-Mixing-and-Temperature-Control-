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
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void entrarBtn_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text.Trim();
            string senha = senhaTxt.Text;

            try
            {
                var conn = Conexao.ObterConexao();

                string query = "SELECT * FROM Funcionario WHERE email = @email AND senha = @senha LIMIT 1";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@senha", senha);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nomeFuncionario = reader["nome"].ToString();
                            int idFuncionario = Convert.ToInt32(reader["idFuncionario"]);
                            int cargoId = Convert.ToInt32(reader["cargos_idcargos"]);

                            reader.Close(); // IMPORTANTE: Fechar antes de fazer novo comando

                            string cargoFuncionario = "";

                            using (MySqlCommand cargoCmd = new MySqlCommand("SELECT nome FROM cargos WHERE idcargos = @id", conn))
                            {
                                cargoCmd.Parameters.AddWithValue("@id", cargoId);
                                object resultadoCargo = cargoCmd.ExecuteScalar();
                                cargoFuncionario = resultadoCargo != null ? resultadoCargo.ToString() : "Desconhecido";
                            }

                            MessageBox.Show("Login realizado com sucesso!");

                            this.Hide();
                            var painel = new Principal(nomeFuncionario, idFuncionario, cargoFuncionario);
                            painel.Show();
                        }
                        else
                        {
                            MessageBox.Show("Email ou senha incorretos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao fazer login: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }
    }
}
