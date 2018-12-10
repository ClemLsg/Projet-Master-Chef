using Kitchen_Simulation.Models.Ingredients;
using Kitchen_Simulation.Models.Tools;

namespace Kitchen_Simulation.Models.Recipes
{
    public class Gaspatcho : Recipe
    {
        public override RecipeTypes RecipeTypes => RecipeTypes.Starter;

        protected override void CreateTools()
        {
            this.Tools.Add(new Louche());
        }

        protected override void CreateIngredients()
        {
            this.AddIngredients(new Tomate(), 1);
            this.AddIngredients(new Oignon(), 1);
            this.AddIngredients(new Concombre(), 1);
            this.AddIngredients(new PainRassi(), 1);
            this.AddIngredients(new HuileDOlive(), 1);
            this.AddIngredients(new Vinaigre(), 1);
            this.AddIngredients(new Poivron(), 1);
            this.AddIngredients(new Sel(), 1);
            this.AddIngredients(new Poivre(), 1);
        }
    }
}