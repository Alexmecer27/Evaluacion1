using Evaluacion1.config;
using Evaluacion1.models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.controllers
{
    internal class IngredienteController
    {
        private ConexionBDD conexion;

        public IngredienteController(ConexionBDD conexion)
        {
            this.conexion = conexion;
        }

        public List<Ingrediente> ObtenerIngredientes()
        {
            List<Ingrediente> ingredientes = new List<Ingrediente>();
            string consulta = "SELECT * FROM Ingredientes";
            SqlConnection conexionAbierta = conexion.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionAbierta);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Ingrediente ingrediente = new Ingrediente();
                ingrediente.IngredienteId = lector.GetInt32(0);
                ingrediente.Nombre = lector.GetString(1);
                ingrediente.Cantidad = lector.GetDecimal(2);
                ingrediente.Unidad = lector.GetString(3);
                ingrediente.Calorias = lector.GetInt32(4);
                ingredientes.Add(ingrediente);
            }
            lector.Close();
            conexion.CerrarConexion();
            return ingredientes;
        }
    }
}
  
