using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace InterfazGYM2
{
    public class DBcomun
    {
        public static SqlConnection ObtenerCOnexion()
        {
            SqlConnection Conn = new SqlConnection("Data Source=CADOR\\SQLEXPRESS;Initial Catalog=Gimnasiodb;Integrated Security=True");
            Conn.Open();

            return Conn;
        }
    }
}
