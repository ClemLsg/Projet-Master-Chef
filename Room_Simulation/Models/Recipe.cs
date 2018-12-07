using System.Collections.Generic;

namespace Room_Simulation.Models
{
    public class Recipe
    {
        public string Name { get; set; }
        public RecipeTypes Type { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        
        public Recipe(string name, RecipeTypes type, List<Ingredient> ingredients)
        {
            this.Name = name;
            this.Type = type;
            this.Ingredients = ingredients;
        }
    }
}