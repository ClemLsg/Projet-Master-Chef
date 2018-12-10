using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Tools;

namespace Kitchen_Simulation.Models
{
    public class KitchenClerk
    {
        public bool IsFree { get; private set; } = true;

        public KitchenClerk()
        {
        }

        public void BringIngredient(Ingredient ingredient, int quantity)
        {
            this.IsFree = false;
        }

        public void OnNotify(Plate plate)
        {
            if (this.IsFree)
            {
                //envoyer a la salle (Socket)
            }

        }
    }
}
