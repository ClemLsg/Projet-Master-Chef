﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Room_Simulation.Models.Ingredients;
using Kitchen_Simulation.Models.Tools;

namespace Room_Simulation.Models.Recipes
{
    class SalmonAvocado : Recipe
    {
        public override RecipeTypes RecipeTypes => RecipeTypes.Starter;
        protected override void CreateTools()
        {
            this.Tools.Add(new Louche());
        }
        protected override void CreateIngredients()
        {
            this.AddIngredients(new Salmon(), 1);
            this.AddIngredients(new Avocado(), 1);
        }
    }
}
