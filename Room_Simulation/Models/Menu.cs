using System.Collections.Generic;

namespace Room_Simulation.Models
{
    public class Menu
    {
        public List<Recipe> Recipes { get; set; }
        public Recipe MealOfTheDay { get; set; }
        
        public Menu(List<Recipe> recipes, Recipe mealOfTheDay)
        {
            this.Recipes = recipes;
            this.MealOfTheDay = mealOfTheDay;
        }
    }
}