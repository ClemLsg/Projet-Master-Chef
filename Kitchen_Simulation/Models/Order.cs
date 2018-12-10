using Kitchen_Simulation.Models.Recipes;

namespace Kitchen_Simulation.Models
{
    public class Order
    {
        public Recipe Starter { get; set; }
        public Recipe Main { get; set; }
        public Recipe Dessert { get; set; }
        
        public Order(Recipe starter, Recipe main, Recipe dessert)
        {
            this.Starter = starter;
            this.Main = main;
            this.Dessert = dessert;
        }
    }
}