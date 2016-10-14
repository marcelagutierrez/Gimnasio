using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfazGYM2
{
    public class cliente
    {
        public int cedula { get; set; }
        public string nombre { get; set; }
        //public double peso { get; set; }
        //public double altura { get; set; }
        public int imc { get; set; }
        public int indice_habitos { get; set; }
        public string indice_salud { get; set; }


        public cliente()
        {
        }
        public cliente (int pcedula, string pnombre, int pimc, int pindice_habitos, string pindice_salud)
        {
            this.cedula = pcedula;
            this.nombre = pnombre;
            this.imc = pimc;
            this.indice_habitos = pindice_habitos;
            this.indice_salud = pindice_salud;

            
        }
    }
}
