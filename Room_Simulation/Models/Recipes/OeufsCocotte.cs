using Room_Simulation.Models.Ingredients;
using Kitchen_Simulation.Models.Tools;

namespace Room_Simulation.Models.Recipes
{
    public class OeufsCocotte : Recipe
    {
        public override RecipeTypes RecipeTypes => RecipeTypes.Starter;
        protected override void CreateTools()
        {
            this.Tools.Add(new Louche());
        }
        protected override void CreateIngredients()
        {
            Ingredients.Add(new Oeuf(), 1);
            Ingredients.Add(new GruyereRape(), 1);
            Ingredients.Add(new Sel(), 1);
            Ingredients.Add(new CremeFraiche(), 1);
            Ingredients.Add(new Poivre(), 1);
        }
    }
}