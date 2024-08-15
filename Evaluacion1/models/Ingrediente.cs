using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1.models
{
    internal class Ingrediente
    {
public int IngredienteId { get; set; }
    public string Nombre { get; set; }
    public decimal Cantidad { get; set; }
    public string Unidad { get; set; }
    public int Calorias { get; set; }
    public List<RecetaIngrediente> RecetaIngredientes { get; set; }
    }
}
