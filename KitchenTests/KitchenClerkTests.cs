﻿using System;
using System.Collections.Generic;
using System.Linq;
using Kitchen_Simulation.Models;
using Kitchen_Simulation.Models.Ingredients;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace KitchenTests
{
    [TestClass]
    public class KitchenClerkTests
    {
        

        
        [TestMethod]
        public void getIngredients()
        {
            KitchenClerk kitchenClerk = new KitchenClerk();
            kitchenClerk.IngredientsList = new List<Ingredient>();
            Sel salt = new Sel();
            Tomate tomato = new Tomate();
            Oeuf egg = new Oeuf();

            List<Ingredient> Ingredients = new List<Ingredient>();
            Ingredients.Add(salt);
            Ingredients.Add(tomato);
            Ingredients.Add(egg);

            kitchenClerk.IngredientsList.Add(salt);
            kitchenClerk.IngredientsList.Add(tomato);
            kitchenClerk.IngredientsList.Add(egg);

            Assert.AreEqual(Ingredients.ElementAt(1), kitchenClerk.IngredientsList.ElementAt(1));



        }
    }
}