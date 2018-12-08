using Room_Simulation.Models.Ingredients;

namespace Room_Simulation.Models.Recipes
{
    public class PateDePorc : Recipe
    {
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