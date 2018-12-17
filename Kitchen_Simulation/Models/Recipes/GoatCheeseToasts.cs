using Kitchen_Simulation.Models;
using Kitchen_Simulation.Models.Ingredients;
using Kitchen_Simulation.Models.Recipes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Tools;

namespace Room_Simulation.Models.Recipes
{
    class GoatCheeseToasts : Recipe
    {
        public override RecipeTypes RecipeTypes => RecipeTypes.Starter;
        protected override void CreateTools()
        {
            this.Tools.Add(new Louche());
        }
        protected override void CreateIngredients()
        {
            this.AddIngredients(new GoatCheese(), 1);
            this.AddIngredients(new Bread(), 1);
        }
    }
}
