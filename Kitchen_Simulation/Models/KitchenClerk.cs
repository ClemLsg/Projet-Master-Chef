using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Models
{
    public class KitchenClerk
    {
        public bool IsFree { get; private set; } = true;

        public void pellVegetable()
        {
            
        }

        public void BringIngredient(Ingredient ingredient, int quantity)
        {
            this.IsFree = false;
        }
    }
}
