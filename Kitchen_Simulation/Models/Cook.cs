using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<Ingredient> AskIngredient(Recipe recipe)
        {
            return recipe.Ingredients;
        }
    }
}
