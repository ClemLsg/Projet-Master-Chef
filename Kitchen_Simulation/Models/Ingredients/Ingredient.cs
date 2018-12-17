using Kitchen_Simulation.Models.Ingredients;

namespace Kitchen_Simulation.Models
{
    public abstract class Ingredient
    {
        public abstract IngredientTypes IngredientTypes { get; }
    }
}