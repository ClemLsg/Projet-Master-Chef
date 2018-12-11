using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Recipes;
using Kitchen_Simulation.Models.Tools;

namespace Kitchen_Simulation.Models
{
    public class Cook
    {
        public Recipe CookingRecipe
        {
            private get { return CookingRecipe; }
            set
            {
                CookingRecipe = value;
                NotifyKitchenClerk(this.MakeRecipe());
                NotifyChef("Order completed", this);
            }
        }

        public List<KitchenClerk> KitchenClerks { get; private set; }
        private List<Tool> Tools { get; set; }
        public Cleaner Cleaner { get; set; }

        private KitchenModel _Model;

        public Cook(List<KitchenClerk> kitchenClerks, List<Tool> tools, Cleaner cleaner, KitchenModel Model)
        {
            this.KitchenClerks = kitchenClerks;
            this.Tools = tools;
            this.Cleaner = cleaner;
            this._Model = Model;
        }

        private Plate MakeRecipe()
        {
            Dictionary<Ingredient, int> ingredients = this.CookingRecipe.Ingredients;
            List<Tool> toolsNeeded = this.CookingRecipe.Tools;
            List<Tool> toolsReserved = new List<Tool>();

            foreach (Tool tool in toolsNeeded)
            {
                Tool fTool = this.Tools.Find(xTool => xTool.GetType().Name == tool.GetType().Name);
                if (fTool == null)
                    break;

                fTool.IsFree = false;
                toolsReserved.Add(fTool);
            }

            foreach (var item in ingredients)
            {
                this.AskIngredient(item.Key, item.Value, this.GetFreeKitchenClerk());
            }

            this.Cleaner.LaunchDishMachine(toolsReserved);
            return this.AssembleIngredients(ingredients.Keys.ToList());
        }

        private Plate AssembleIngredients(List<Ingredient> ingredients)
        {
            return new Plate(this.CookingRecipe);
        }

        private KitchenClerk GetFreeKitchenClerk()
        {
            KitchenClerk kitchenClerkFree = null;

            while (kitchenClerkFree == null)
            {
                foreach (KitchenClerk kitchenClerk in this.KitchenClerks)
                {
                    if (kitchenClerk.IsFree)
                        kitchenClerkFree = kitchenClerk;
                }
            }

            return kitchenClerkFree;
        }

        public void AskIngredient(Ingredient ingredient, int quantity, KitchenClerk kitchenClerk)
        {
            kitchenClerk.BringIngredient(ingredient, quantity);
        }

        public void NotifyKitchenClerk(Plate plate)
        {
            foreach (var kc in KitchenClerks)
            {
                kc.OnNotify(plate);
            }
        }

        public void NotifyChef(string value, Cook c)
        {
            Chef.Instance.OnCookNotify(value, c);
        }
    }
}
