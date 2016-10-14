using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InterfazGYM2
{
    public partial class MenuRegistro : Form
    {
        public MenuRegistro()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registro = new Registro();
            registro.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form consultar = new consultar_cliente();
            consultar.Show();
        }

        private void MenuRegistro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
