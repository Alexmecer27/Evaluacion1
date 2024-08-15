using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Evaluacion1.config
{
    internal class ConexionBDD
    {
        private readonly SqlConnection con;

        public ConexionBDD()
        {
         con = new SqlConnection(connectionString: "Server=ALEXMERCER27\\SQLSERVER;database=Gestionrecetas;");
           }

        public SqlConnection AbrirConexion()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }

        public void CerrarConexion()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
    }
}
