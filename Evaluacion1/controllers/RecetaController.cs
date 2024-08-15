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
    internal class RecetaController
    {
        private ConexionBDD conexion;

        public RecetaController(ConexionBDD conexion)
        {
            this.conexion = conexion;
        }

        public List<Receta> ObtenerRecetas()
        {
            List<Receta> recetas = new List<Receta>();
            string consulta = "SELECT * FROM Recetas";
            SqlConnection conexionAbierta = conexion.AbrirConexion();
            SqlCommand comando = new SqlCommand(consulta, conexionAbierta);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Receta receta = new Receta();
                receta.RecetaId = lector.GetInt32(0);
                receta.Nombre = lector.GetString(1);
                receta.Descripcion = lector.GetString(2);
                receta.TiempoPreparacion = lector.GetInt32(3);
                receta.Dificultad = lector.GetString(4);
                recetas.Add(receta);
            }
            lector.Close();
            conexion.CerrarConexion();
            return recetas;
        }
    }                                                       
}
