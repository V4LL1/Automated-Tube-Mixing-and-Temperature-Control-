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

            double tempLblValue = double.Parse(tempLbl.Text);  // Ou use TryParse para evitar exceções

            // Verifica se txtTemp é um número válido
            if (double.TryParse(txtTemp.Text, out double txtTempValue))
            {
                if (tempLblValue < txtTempValue)
                {
                    EnviarComando("ON1:10");
                }
                else
                {
                    EnviarComando("ON2:10");
                }
            }
            else
            {
                MessageBox.Show("O valor de temperatura inserido é inválido.");
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
