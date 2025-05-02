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
    public partial class Historico : Form
    {
        public Historico()
        {
            InitializeComponent();
        }

        private void Historico_Load(object sender, EventArgs e)
        {
            try
            {
                var conn = Conexao.ObterConexao();

                string query = @"SELECT 
                            M.idExperimento, 
                            M.temperatura, 
                            M.tempo, 
                            F.nome AS Funcionario, 
                            P.nome AS Paciente
                        FROM Mistura M
                        JOIN Funcionario F ON M.Funcionario_idFuncionario = F.idFuncionario
                        JOIN Frasco Fr ON M.Frasco_idFrasco = Fr.idFrasco
                        JOIN Paciente P ON Fr.Paciente_idPaciente = P.idPaciente";

                using (MySqlDataAdapter da = new MySqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    historicoGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar histórico: " + ex.Message);
            }
            finally
            {
                Conexao.FecharConexao();
            }
        }
    }
}
