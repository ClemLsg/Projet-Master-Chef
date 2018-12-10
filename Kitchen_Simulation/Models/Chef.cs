﻿using System;
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
        private List<Recipe> _recipePool = null;
        private List<Cook> _waitingCooks = null;

        private Chef()
        {
         
        }

        public static Chef Instance => _instance ?? (_instance = new Chef());

        public void AddToPool(Recipe recipe)
        {
            this._recipePool.Add(recipe);
        }

        public void AssignOrder(Cook cook, Recipe recipe)
        {
            cook.CookingRecipe = recipe;
        }
        
        public void ReciveNewOrder(Order order)
        {
            AddToPool(order.Starter);
            AddToPool(order.Main);
            AddToPool(order.Dessert);
            if (_waitingCooks.Any())
            {
                AssignOrder(_waitingCooks.First(), _recipePool.First());
            }
        }

        public void OnCookNotify(string value, Cook c)
        {
            if (value == "Order completed")
            {
                if(_recipePool.Any())
                {
                    AssignOrder(c, _recipePool.First());
                } else
                {
                    _waitingCooks.Add(c);
                }
                
            }

        }
    }
}
