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
    public partial class Registro : Form
    {
        public double peso;
        public double altura;
        public int IMC;
        public double aux;
        public double aux2;
        public int cedula;
        public string nombre;
        public int indice_habitos;
        public string indice_salud;
        
        
        
        public Registro()
        {
            InitializeComponent();
            button3.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void button5_Click(object sender, EventArgs e)
        {
            Form menuP = new MenuRegistro();
            menuP.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                peso = Convert.ToDouble(textBox3.Text);
                altura = Convert.ToDouble(textBox4.Text);

                IMC =  Convert.ToInt32( (peso / (Math.Pow(altura, 2)))*10000);
                

                label5.Text = IMC.ToString();
                aux = 1;
                button3.Enabled = true;
                
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Ingreso un dato incorrecto o falto ingresar datos", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (aux == 1)
            {

                if (IMC <= 24)
                {
                    MessageBox.Show("se rrecomienda hacer Rutina de Musculacion", "Recomendacion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (IMC > 24)
                {
                    MessageBox.Show("se rrecomienda hacer Rutina de Definicion", "Recomendacion",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            aux = 0;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                cedula = Convert.ToInt32(textBox1.Text);
                nombre = Convert.ToString(textBox2.Text);
                aux2 = 1;
            }
            catch (System.FormatException)
            {

                MessageBox.Show("Ingreso un dato incorrecto o falto ingresar datos", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            int de_pie = Convert.ToInt32(comboBox1.Text);
            int correr = Convert.ToInt32(comboBox2.Text);
            int movrepetitivos = Convert.ToInt32(comboBox3.Text);

            indice_habitos = (de_pie + correr + movrepetitivos) / 3;
            indice_salud = comboBox4.Text;
            

            cliente cliente = new cliente();

            if (aux2 == 1)
            { 
                
                cliente.cedula = cedula;
                cliente.nombre = nombre;
                //cliente.peso = Convert.ToInt32(peso);
                //cliente.altura = Convert.to altura;
                cliente.imc = IMC;
                cliente.indice_habitos = indice_habitos;
                cliente.indice_salud = indice_salud;
            
                int resultado = clienteDAL.Agregar(cliente);

                if (resultado > 0)
                {
                    MessageBox.Show("Datos guardados correctamente", "Datos guerdados", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se guardaron los datos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                

            }
            aux2 = 0;
            
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
