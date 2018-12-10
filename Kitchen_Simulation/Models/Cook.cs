using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Recipes;

namespace Kitchen_Simulation.Models
{
    public class Cook
    {
        private Recipe CookingRecipe;

        internal Recipe GetCookingRecipe()
        {
            return CookingRecipe;
        }

        internal void SetCookingRecipe(Recipe value)
        {
            CookingRecipe = value;
        }

        public void GetTool()
        {

        }

        public void FreeTool()
        {

        }

        public void BringTool()
        {

        }

        public Dictionary<Ingredient, int> AskIngredient(Recipe recipe)
        {
            return CookingRecipe.Ingredients;
        }
    }
}
