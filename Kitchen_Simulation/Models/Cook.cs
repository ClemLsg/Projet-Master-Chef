using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Models
{
    class Cook
    {
        public void GetTool()
        {

        }

        public void FreeTool()
        {

        }

        public void BringTool()
        {

        }

        public List<Ingredient> AskIngredient(Recipe recipe)
        {
            return recipe.Ingredients;
        }
    }
}
