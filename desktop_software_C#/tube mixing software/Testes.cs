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

namespace tube_mixing_software
{
    public partial class Testes : Form
    {
        private SerialPort serialPort;
        public Testes()
        {
            InitializeComponent();
            cmbPortas.DataSource = SerialPort.GetPortNames();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort = new SerialPort(cmbPortas.SelectedItem.ToString(), 9600);
                serialPort.DataReceived += SerialPort_DataReceived;
                serialPort.Open();
                txtLog.AppendText("Conectado com sucesso!\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string data = serialPort.ReadLine().Trim();
            Invoke(new Action(() =>
            {
                txtLog.AppendText("Recebido: " + data + "\r\n");

                if (data.StartsWith("TEMP:"))
                {
                    lblTemperatura.Text = data.Substring(5) + " °C";
                }
            }));
        }

        private void EnviarComando(string comando)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                serialPort.WriteLine(comando);
                txtLog.AppendText("Enviado: " + comando + "\r\n");
            }
            else
            {
                MessageBox.Show("Porta serial não conectada.");
            }
        }

        private void btnRele1_Click(object sender, EventArgs e) => EnviarComando("ON1:2");
        private void btnRele2_Click(object sender, EventArgs e) => EnviarComando("ON2:2");
        private void btnRele3_Click(object sender, EventArgs e) => EnviarComando("ON3:2");
        private void btnRele4_Click(object sender, EventArgs e) => EnviarComando("ON4:2");

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
                serialPort.Close();
        }

        private void Testes_Load(object sender, EventArgs e)
        {

        }
    }
}
