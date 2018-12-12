
using Kitchen_Simulation.Models.Tools;
using Room_Simulation.Models.Ingredients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Models.Recipes
{
    class AppleIceCream : Recipe
    {
        public override RecipeTypes RecipeTypes => RecipeTypes.Dessert;
        protected override void CreateTools()
        {
            this.Tools.Add(new Louche());
        }
        protected override void CreateIngredients()
        {
            this.AddIngredients(new AppleIngredient(), 1);
            this.AddIngredients(new IceCream(), 1);
        }
    }
}