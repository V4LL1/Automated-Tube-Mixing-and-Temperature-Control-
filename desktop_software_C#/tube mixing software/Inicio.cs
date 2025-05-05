using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tube_mixing_software
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void EntrarBtn_Click(object sender, EventArgs e)
        {
            Entrar entrar = new Entrar();
            entrar.Show();
        }

        private void SairBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarBtn_Click(object sender, EventArgs e)
        {
            Registar registar = new Registar();
            registar.Show();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            Testes testes = new Testes();
            testes.Show();
        }
    }
}
