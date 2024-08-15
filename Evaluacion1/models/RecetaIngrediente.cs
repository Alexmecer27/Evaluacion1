using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.models
{
    internal class RecetaIngrediente
    {
        public int RecetaId { get; set; }
        public int IngredienteId { get; set; }
        public decimal CantidadReceta { get; set; }
        public Receta Receta { get; set; }
        public Ingrediente Ingrediente { get; set; }
    }
}
