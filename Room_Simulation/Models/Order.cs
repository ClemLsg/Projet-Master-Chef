using System;

namespace Room_Simulation.Models
{
    [Serializable]
    public class Order
    {
        public string Starter { get; set; }
        public string Main { get; set; }
        public string Dessert { get; set; }
        
        public Order(string starter, string main, string dessert)
        {
            this.Starter = starter;
            this.Main = main;
            this.Dessert = dessert;
        }
    }
}