using Evaluacion1.config;
using Evaluacion1.controllers;
using Evaluacion1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion1
{
    public partial class Form1 : Form
    {
        private RecetaController recetaController;
        private IngredienteController ingredienteController;

        public Form1()
        {
            InitializeComponent();
            recetaController = new RecetaController(new ConexionBDD());
            ingredienteController = new IngredienteController(new ConexionBDD());
            LoadRecetas();
            LoadIngredientes();
        }

        private void LoadRecetas()
        {
            listRecetas.Items.Clear();
            List<Receta> recetas = recetaController.ObtenerRecetas();
            foreach (Receta receta in recetas)
            {
                listRecetas.Items.Add(receta.Nombre);
            }
        }

        private void LoadIngredientes()
        {
            listIngreduentes.Items.Clear();
            List<Ingrediente> ingredientes = ingredienteController.ObtenerIngredientes();
            foreach (Ingrediente ingrediente in ingredientes)
            {
                listIngreduentes.Items.Add(ingrediente.Nombre);
            }
        }

        private void buttonAgregarReceta_Click(object sender, EventArgs e)
        {
            // Agregar lógica para agregar una nueva receta
        }

        private void buttonAgregarIngrediente_Click(object sender, EventArgs e)
        {
            // Agregar lógica para agregar un nuevo ingrediente
        }
    }
}
