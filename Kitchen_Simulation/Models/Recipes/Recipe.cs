using System;
using System.Collections.Generic;
using Kitchen_Simulation.Models.Tools;

namespace Kitchen_Simulation.Models.Recipes
{
    public abstract class Recipe
    {
        public Dictionary<Ingredient, int> Ingredients { get; } = new Dictionary<Ingredient, int>();
        public abstract RecipeTypes RecipeTypes { get; }
        public List<Tool> Tools { get; } = new List<Tool>();

        public static List<Recipe> Recipes = new List<Recipe>
        {
            new PateDePorc(),
            new OeufsCocotte(),
            new Gaspatcho(),
        };

        protected Recipe()
        {
            this.CreateIngredients();
            this.CreateTools();
        }

        protected abstract void CreateTools();
        protected abstract void CreateIngredients();

        protected void AddIngredients(Ingredient ingredient, int quantity = 1)
        {
            if (quantity <= 0 )
                throw new ArgumentException();
            
            this.Ingredients.Add(ingredient, quantity);
        }
    }
}