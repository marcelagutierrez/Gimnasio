using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace InterfazGYM2
{
    public class clienteDAL
    {
        public static int Agregar(cliente pCliente)
        {
            int retorno = 0;
            using (SqlConnection conn = DBcomun.ObtenerCOnexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Insert Into clientes (cedula, nombre, imc, indicehabito, indicesalud) values ('{0}','{1}','{2}', '{3}', '{4}')",
                    pCliente.cedula, pCliente.nombre, pCliente.imc, pCliente.indice_habitos, pCliente.indice_salud), conn);

                retorno = comando.ExecuteNonQuery();
            }

            return retorno;
        }
    }
}
