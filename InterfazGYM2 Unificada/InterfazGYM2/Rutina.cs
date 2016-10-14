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
    public partial class Rutina : Form
    {
        string R1;
        string S1;
        string R2;
        string S2;
        string R3;
        string S3;
        string R4;
        string S4;

        public Rutina()
        {
            InitializeComponent();
            label10.Visible = false;
            label11.Visible = false;
        }
        

        private void Rutina_Load(object sender, EventArgs e)
        {

        }
        public void objetivo(int A)
        {
            if (A == 1)
            {
                linkLabel3.Text = "Correr y Aeróbicos";
                linkLabel7.Text = "Correr y Aeróbicos";
            }

            if (A == 2)
            {
                linkLabel3.Visible = false;
                linkLabel7.Visible = false;
                linkLabel4.Visible = false;
                linkLabel8.Visible = false;
                label10.Visible = true;
                label11.Visible = true;
            }
        }

        public void labels_abdominales(string L1, string r,string s)
        {
            linkLabel2.Text = L1;
            linkLabel4.Text = L1;
            linkLabel6.Text = L1;
            linkLabel8.Text = L1;
            linkLabel10.Text = L1;
            this.R1 = r;
            this.S1 = s;

        }

        public void labels_pecho(string L2, string r, string s)
        {
            linkLabel1.Text = L2;
            linkLabel9.Text = L2;
            this.R2 = r;
            this.S2 = s;
        }
        public void labels_pierna(string L3, string r, string s)
        {
            linkLabel11.Text = L3;
            this.R3 = r;
            this.S3 = s;
        }
        public void labels_espalda(string L4, string r, string s)
        {
            linkLabel5.Text = L4;
            linkLabel12.Text = L4;
            this.R4 = r;
            this.S4 = s;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            repeti.Text = R2;
            series.Text = S2;

            panel1.BackgroundImage = Properties.Resources._6;

            /*switch (linkLabel1.Text)
            {
                case "Pecho: Push ups regular":
                    {
                        panel1.BackgroundImage = Properties.Resources.PechoPush_ups_regular_8;
                        break;
                    }
            }*/

        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources._6;

            repeti.Text = R2;
            series.Text = S2;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkLabel2.Text == "Abdominales: Plancha")
            {
                panel1.BackgroundImage = Properties.Resources._3;
            }
            if (linkLabel2.Text == "Abdominales: Crunches")
            {
                panel1.BackgroundImage = Properties.Resources._2;
            }
            repeti.Text = R1;
            series.Text = S1;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel4.Text == "Abdominales: Plancha")
            {
                panel1.BackgroundImage = Properties.Resources._3;
            }
            if (linkLabel4.Text == "Abdominales: Crunches")
            {
                panel1.BackgroundImage = Properties.Resources._2;
            }

            repeti.Text = R1;
            series.Text = S1;
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel6.Text == "Abdominales: Plancha")
            {
                panel1.BackgroundImage = Properties.Resources._3;
            }
            if (linkLabel6.Text == "Abdominales: Crunches")
            {
                panel1.BackgroundImage = Properties.Resources._2;
            }

            repeti.Text = R1;
            series.Text = S1;
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel8.Text == "Abdominales: Plancha")
            {
                panel1.BackgroundImage = Properties.Resources._3;
            }
            if (linkLabel8.Text == "Abdominales: Crunches")
            {
                panel1.BackgroundImage = Properties.Resources._2;
            }

            repeti.Text = R1;
            series.Text = S1;
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (linkLabel10.Text == "Abdominales: Plancha")
            {
                panel1.BackgroundImage = Properties.Resources._3;
            }
            if (linkLabel10.Text == "Abdominales: Crunches")
            {
                panel1.BackgroundImage = Properties.Resources._2;
            }
            repeti.Text = R1;
            series.Text = S1;
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(linkLabel12.Text == "Espalda: Pull Ups")
            {
                panel1.BackgroundImage = Properties.Resources._5;
            }
            if (linkLabel12.Text == "Espalda: Negative Chin Ups")
            {
                panel1.BackgroundImage = Properties.Resources.Espalda_Negative_CHIN_UPS_4;
            }

            repeti.Text = R4;
            series.Text = S4;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel5.Text == "Espalda: Pull Ups")
            {
                panel1.BackgroundImage = Properties.Resources._5;
            }
            if (linkLabel5.Text == "Espalda: Negative Chin Ups")
            {
                panel1.BackgroundImage = Properties.Resources.Espalda_Negative_CHIN_UPS_4;
            }

            repeti.Text = R4;
            series.Text = S4;
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources._11;

            repeti.Text = R3;
            series.Text = S3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Form menup = new MenuRegistro();
            menup.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources.Correr;
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel1.BackgroundImage = Properties.Resources.Correr;
        }
    }
}
