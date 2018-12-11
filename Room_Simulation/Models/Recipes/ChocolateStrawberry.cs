using Room_Simulation.Models.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Models.Recipes
{
    class ChocolateStrawberry : Recipe
    {
        public override RecipeTypes RecipeTypes => RecipeTypes.Starter;

        protected override void CreateIngredients()
        {
            this.AddIngredients(new Chocolate(), 1);
            this.AddIngredients(new Strawberry(), 1);
        }
    }
}
