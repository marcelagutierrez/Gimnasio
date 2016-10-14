using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InterfazGYM2
{
    public partial class consultar_cliente : Form
    {

        private int cedula;
        private int aux;
        public consultar_cliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form menuP = new MenuRegistro();
            menuP.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cedulabusqueda = textBox1.Text;
            string indice_habitoCliente = null;
            string indice_salud = null;

            Rutina rutina = new Rutina();

            if (comboBox1.Text == "Definicion")
            {
                rutina.objetivo(1);
            }

            if (comboBox1.Text == "Musculacion")
            {
                rutina.objetivo(2);
            }
            if (comboBox1.Text != "")
            {




                using (SqlConnection conn = DBcomun.ObtenerCOnexion())
                {

                    int auxCliente = 0;



                    SqlDataReader clienteread = null;
                    SqlCommand comandocliente = new SqlCommand("Select * from clientes", conn);
                    clienteread = comandocliente.ExecuteReader();


                    while (clienteread.Read())
                    {
                        if (clienteread["cedula"].ToString() == cedulabusqueda)
                        {
                            indice_habitoCliente = Convert.ToString(clienteread["indicehabito"]);
                            indice_salud = Convert.ToString(clienteread["indicesalud"]);
                            auxCliente = 1;
                        }
                    }
                    if (auxCliente == 0)
                    {
                        MessageBox.Show("El cliente con cedula " + cedulabusqueda + " no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (auxCliente == 1)
                    {
                        clienteread.Close();
                        SqlDataReader absread = null;
                        SqlCommand comandoabs = new SqlCommand("Select * from abdominalesTabla", conn);

                        absread = comandoabs.ExecuteReader();



                        if (indice_salud == "Ninguno" | indice_salud != "Espalda")
                        {
                            while (absread.Read())
                            {
                                if (absread["indicehabitoejercicio"].ToString() == indice_habitoCliente)
                                {
                                    rutina.labels_abdominales(Convert.ToString(absread["nombre"]), Convert.ToString(absread["repeticiones"]), Convert.ToString(absread["series"]));
                                }
                            }
                        }
                        else
                        {
                            while (absread.Read())
                            {
                                if (absread["indicehabitoejercicio"].ToString() == "0")
                                {
                                    rutina.labels_abdominales(Convert.ToString(absread["nombre"]), Convert.ToString(absread["repeticiones"]), Convert.ToString(absread["series"]));
                                }
                            }
                        }

                        //------------------------BUSQUEDA EJERCICIOS DE PECHO--------------------------//
                        absread.Close();
                        SqlDataReader pechoread = null;
                        SqlCommand comandpecho = new SqlCommand("Select * from pechoTabla", conn);

                        pechoread = comandpecho.ExecuteReader();



                        if (indice_salud == "Ninguno" | indice_salud != "Brazos")
                        {
                            while (pechoread.Read())
                            {
                                if (pechoread["indicehabitoejercicio"].ToString() == indice_habitoCliente)
                                {
                                    rutina.labels_pecho(Convert.ToString(pechoread["nombre"]), Convert.ToString(pechoread["repeticiones"]), Convert.ToString(pechoread["series"]));
                                }
                            }
                        }
                        else
                        {
                            while (pechoread.Read())
                            {
                                if (pechoread["indicehabitoejercicio"].ToString() == "0")
                                {
                                    rutina.labels_pecho(Convert.ToString(pechoread["nombre"]), Convert.ToString(pechoread["repeticiones"]), Convert.ToString(pechoread["series"]));
                                }
                            }
                        }

                        //------------------------BUSQUEDA EJERCICIOS DE PIERNA--------------------------//
                        pechoread.Close();
                        SqlDataReader piernaread = null;
                        SqlCommand comandpierna = new SqlCommand("Select * from piernaTabla", conn);

                        piernaread = comandpierna.ExecuteReader();



                        if (indice_salud == "Ninguno" | indice_salud != "Pierna")
                        {
                            while (piernaread.Read())
                            {
                                if (piernaread["indicehabitoejercicio"].ToString() == indice_habitoCliente)
                                {
                                    rutina.labels_pierna(Convert.ToString(piernaread["nombre"]), Convert.ToString(piernaread["repeticiones"]), Convert.ToString(piernaread["series"]));
                                }
                            }
                        }
                        else
                        {
                            while (piernaread.Read())
                            {
                                if (piernaread["indicehabitoejercicio"].ToString() == "0")
                                {
                                    rutina.labels_pierna(Convert.ToString(piernaread["nombre"]), Convert.ToString(piernaread["repeticiones"]), Convert.ToString(piernaread["series"]));
                                }
                            }
                        }

                        //------------------------BUSQUEDA EJERCICIOS DE ESPALDA--------------------------//
                        piernaread.Close();
                        SqlDataReader espaldaread = null;
                        SqlCommand comandespalda = new SqlCommand("Select * from espaldaTabla", conn);

                        espaldaread = comandespalda.ExecuteReader();



                        if (indice_salud == "Ninguno" | indice_salud != "Brazos")
                        {
                            while (espaldaread.Read())
                            {
                                if (espaldaread["indicehabitoejercicio"].ToString() == indice_habitoCliente)
                                {
                                    rutina.labels_espalda(Convert.ToString(espaldaread["nombre"]), Convert.ToString(espaldaread["repeticiones"]), Convert.ToString(espaldaread["series"]));
                                }
                            }
                        }
                        else
                        {
                            while (espaldaread.Read())
                            {
                                if (espaldaread["indicehabitoejercicio"].ToString() == "0")
                                {
                                    rutina.labels_espalda(Convert.ToString(espaldaread["nombre"]), Convert.ToString(espaldaread["repeticiones"]), Convert.ToString(espaldaread["series"]));
                                }
                            }
                        }

                        this.Hide();
                        rutina.Show();


                    }


                }

                try
                {
                    cedula = Convert.ToInt32(textBox1.Text);
                    aux = 1;
                }
                catch (System.FormatException)
                {

                    MessageBox.Show("Ingreso un dato incorrecto o falto ingresar datos", "ERROR",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }


            }
            else
            {
                MessageBox.Show("Debe elejir un objetivo para la rutina", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        
    }
}
