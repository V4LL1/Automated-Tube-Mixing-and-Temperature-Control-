using System;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace tube_mixing_software
{
    public partial class Testes : Form
    {
        public Testes()
        {
            InitializeComponent();
        }

        private void Testes_Load(object sender, EventArgs e)
        {
            string[] portas = SerialPort.GetPortNames();
            cmbPortas.DataSource = portas;
            if (portas.Contains("COM3"))
                cmbPortas.SelectedItem = "COM3";
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = SerialManager.Port.ReadLine().Trim();
                if (data.StartsWith("TEMP:"))
                {
                    SerialManager.UltimaTemperatura = data.Substring(5);
                }

                BeginInvoke(new Action(() =>
                {
                    txtLog.AppendText("Recebido: " + data + "\r\n");
                }));
            }
            catch (Exception ex)
            {
                BeginInvoke(new Action(() =>
                {
                    txtLog.AppendText("Erro de leitura: " + ex.Message + "\r\n");
                }));
            }
        }

        private void EnviarComando(string comando)
        {
            if (SerialManager.Port != null && SerialManager.Port.IsOpen)
            {
                SerialManager.Port.WriteLine(comando);
                txtLog.AppendText("Enviado: " + comando + "\r\n");
            }
            else
            {
                MessageBox.Show("Porta serial não conectada.");
            }
        }

        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            try
            {
                SerialManager.Port = new SerialPort(cmbPortas.SelectedItem.ToString(), 9600);
                SerialManager.Port.DataReceived += SerialPort_DataReceived;
                SerialManager.Port.Encoding = Encoding.ASCII;
                SerialManager.Port.Open();
                txtLog.AppendText("Conectado com sucesso!\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnRele1_Click_1(object sender, EventArgs e)
        {
            EnviarComando("ON1:" + txtTempo.Text);
        }

        private void btnRele2_Click_1(object sender, EventArgs e)
        {
            EnviarComando("ON2:" + txtTempo.Text);
        }

        private void btnRele3_Click_1(object sender, EventArgs e)
        {
            EnviarComando("ON3:" + txtTempo.Text);
        }

        private void btnRele4_Click_1(object sender, EventArgs e)
        {
            EnviarComando("ON4:" + txtTempo.Text);
        }

        private void Testes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (SerialManager.Port != null && SerialManager.Port.IsOpen)
                SerialManager.Port.Close();
        }

    }
}
