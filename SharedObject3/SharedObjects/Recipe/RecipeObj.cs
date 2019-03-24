using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedObject3.SharedObjects.Recipe
{
    public class RecipeObj
    {
        public int RecipeID { get; set; }
        public string Name { get; set; }
        public List<Ingredient> IngredientList { get; set; }
        public double AproxCost { get; set; }
        public int Servings { get; set; }
        public bool Healthy { get; set; }
    }
}
