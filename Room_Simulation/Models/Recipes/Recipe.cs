using System;
using System.Collections.Generic;

namespace Room_Simulation.Models.Recipes
{
    public abstract class Recipe
    {
        public Dictionary<Ingredient, int> Ingredients { get; } = new Dictionary<Ingredient, int>();

        public static List<Recipe> Recipes = new List<Recipe>
        {
            new PateDePorc(),
        };

        public Recipe()
        {
            this.CreateIngredients();
        }

        protected abstract void CreateIngredients();

        protected void AddIngredients(Ingredient ingredient, int quantity = 1)
        {
            this.Ingredients.Add(ingredient, quantity);
        }
    }
}