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

        private static Chef instance = null;
        private static readonly object padlock = new object();

        Chef()
        {
        }

        public static Chef Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Chef();
                    }
                    return instance;
                }
            }
        }

        public void AssignOrder(Cook c, Recipe r)
        {
            c.SetCookingRecipe(r);
        }
    }
}
