using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Room_Simulation.Models.Recipes;

namespace Room_Simulation.Models
{
    public class Menu
    {
        private static Menu _instance = null; // Menu instance
        public static Menu Instance => _instance ?? (_instance = new Menu()); //Singleton

        public List<Recipe> Recipes { get; } = new List<Recipe>();
        public Recipe MealOfTheDay { get; }
        
        private Menu()
        {
            this.CreateMenu();
            
            this.MealOfTheDay = Recipes[(new Random()).Next(0, Recipes.Count)];
        }

        private void CreateMenu()
        {
            List<Recipe> recipes = Recipe.Recipes;
            
            for (int i = 0; i < 10; i++)
            {
                Random randomGen = new Random();
                int random = randomGen.Next(0, recipes.Count);
                
                this.Recipes.Add(recipes[random]);
                recipes.Remove(recipes[random]);

                if (recipes.Count <= 0)
                    break;
            }
        }
    }
}