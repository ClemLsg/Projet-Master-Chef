using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Models
{
    class Recipe
    {

        public string Name { get; set; }
        internal RecipeType Type { get; set; }
        internal List<Ingredient> Ingredients { get; set; }
    }
}
