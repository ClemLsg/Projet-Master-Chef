using System;
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
        KitchenClerk kitchenClerk = new KitchenClerk();

        
        [TestMethod]
        public void getIngredients()
        {
            
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

            Assert.AreEqual();



        }
    }
}
