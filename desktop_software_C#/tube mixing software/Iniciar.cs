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

namespace tube_mixing_software
{
    public partial class Iniciar : Form
    {
        public Iniciar()
        {
            InitializeComponent();
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

        }
    }
}
