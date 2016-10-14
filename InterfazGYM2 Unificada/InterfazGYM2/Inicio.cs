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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            Form menuP = new MenuRegistro();
            menuP.Show();
        }

       
    }
}
