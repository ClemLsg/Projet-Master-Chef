using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Recipes;

namespace Kitchen_Simulation.Models
{
    public sealed class Chef
    {
        private static Chef _instance = null;

        private Chef()
        {
        }

        public static Chef Instance => _instance ?? (_instance = new Chef());

        public void AssignOrder(Cook cook, Recipe recipe)
        {
            cook.CookingRecipe = recipe;
        }
    }
}
