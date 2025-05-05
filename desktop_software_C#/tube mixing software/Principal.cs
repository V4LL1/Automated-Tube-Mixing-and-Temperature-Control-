using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace tube_mixing_software
{
    public partial class Principal : Form
    {
        private string nomeFuncionario;
        private int idFuncionario;
        private string cargoFuncionario;

        private System.Windows.Forms.Timer timerAtualizaTemp;

        public Principal(string nome, int id, string cargo)
        {
            InitializeComponent();
            nomeFuncionario = nome;
            idFuncionario = id;
            cargoFuncionario = cargo;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            funcionarioLbl.Text = $"Bem-vindo, {nomeFuncionario}\nID: {idFuncionario}\nCargo: {cargoFuncionario}";

            timerAtualizaTemp = new System.Windows.Forms.Timer();
            timerAtualizaTemp.Interval = 1000; // Atualiza a cada 1 segundo
            timerAtualizaTemp.Tick += TimerAtualizaTemp_Tick;
            timerAtualizaTemp.Start();
        }

        private void TimerAtualizaTemp_Tick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SerialManager.UltimaTemperatura))
            {
                tempLbl.Text = SerialManager.UltimaTemperatura + " °C";
            }
        }

        private void iniciarBtn_Click(object sender, EventArgs e)
        {
            if (cargoFuncionario == "Técnico em Análises Clínicas")
            {
                Iniciar iniciar = new Iniciar();
                iniciar.Show();
            }
            else
            {
                MessageBox.Show("Apenas Técnicos em Análises Clínicas podem acessar esta função.",
                                "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void sairBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void historicoBtn_Click(object sender, EventArgs e)
        {
            if (cargoFuncionario.Trim().Equals("Gerente de Qualidade", StringComparison.OrdinalIgnoreCase))
            {
                Historico historico = new Historico();
                historico.Show();
            }
            else
            {
                MessageBox.Show("Apenas Gerentes de Qualidade podem acessar esta função.",
                                "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
