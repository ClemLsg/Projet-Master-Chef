using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kitchen_Simulation.Models.Recipes;

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
                notifyKitchenClerk(this.MakeRecipe());
            }
        }

        public List<KitchenClerk> KitchenClerks { get; private set; }

        public Cook(List<KitchenClerk> kitchenClerks)
        {
            this.KitchenClerks = kitchenClerks;
        }

        private Plate MakeRecipe()
        {
            Dictionary<Ingredient, int> ingredients = this.CookingRecipe.Ingredients;

            foreach (var item in ingredients)
            {
                this.AskIngredient(item.Key, item.Value, this.GetFreeKitchenClerk());
            }

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
    }
}
