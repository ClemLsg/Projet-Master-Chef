using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Tools;

namespace Kitchen_Simulation.Models
{
    public class KitchenClerk
    {
        public bool IsFree { get; private set; } = true;
        private KitchenModel _Model;

        public KitchenClerk(KitchenModel Model)
        {
            this._Model = Model;
        }

        public void BringIngredient(Ingredient ingredient, int quantity)
        {
            this._Model.GetController().Animation("GoToStockCom");
            this.IsFree = false;
            this._Model.GetController().Animation("GoToCookCom");
        }

        public void OnNotify(Plate plate)
        {
            if (this.IsFree)
            {
                this._Model.GetController().Animation("GoToExCom");
                NetworkManager.StartClient(plate);
            }

        }

    }
}
