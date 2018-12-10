using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Room_Simulation.Models;

namespace RoomTests
{
    [TestClass]
    public class MenuTests
    {
        Room_Simulation.Models.Recipes.PateDePorc pateDePorc = new Room_Simulation.Models.Recipes.PateDePorc();
        Room_Simulation.Models.Recipes.Gaspatcho gaspaccio = new Room_Simulation.Models.Recipes.Gaspatcho();
        Room_Simulation.Models.Recipes.OeufsCocotte oeufsCocotte = new Room_Simulation.Models.Recipes.OeufsCocotte();


        [TestMethod]
        public void SetMealOfTheDay()
        {
            if (Menu.Instance.MealOfTheDay.ToString() == pateDePorc.ToString())
            {
                Assert.AreEqual(pateDePorc.GetType().ToString(), Menu.Instance.MealOfTheDay.GetType().ToString());
            }
            else
            {
                if(Menu.Instance.MealOfTheDay.ToString() == gaspaccio.ToString())
                {
                    Assert.AreEqual(gaspaccio.GetType().ToString(), Menu.Instance.MealOfTheDay.GetType().ToString());
                }
                else
                {
                    if(Menu.Instance.MealOfTheDay.ToString() == oeufsCocotte.ToString())
                    {
                        Assert.AreEqual(oeufsCocotte.GetType().ToString(), Menu.Instance.MealOfTheDay.GetType().ToString());
                    }
                    else
                    {
                        Assert.AreEqual("menu not find", Menu.Instance.MealOfTheDay.GetType().ToString());
                    }
                }
            }

        }
    }
}
