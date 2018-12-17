using Kitchen_Simulation.Models.Ingredients;
using Kitchen_Simulation.Models.Tools;

namespace Kitchen_Simulation.Models.Recipes
{
    public class PateDePorc : Recipe
    {
        public override RecipeTypes RecipeTypes => RecipeTypes.Main;

        protected override void CreateTools()
        {
            this.Tools.Add(new Louche());
        }

        protected override void CreateIngredients()
        {
            this.AddIngredients(new Poitrine(), 2);
            this.AddIngredients(new Foie(), 1);
            this.AddIngredients(new Oeuf(), 12);
            this.AddIngredients(new Sel(), 1);
            this.AddIngredients(new Poivre(), 1);
        }
    }
}