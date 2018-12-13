namespace Room_Simulation.Models
{
    public class Client
    {
        public bool IsServed { get; set; }
        public Order AOrder { get; set; }
        
        public Client()
        {

        }

        public void Pay()
        {
            //Client go to bar
            //Client pay
            //Client leave the room 
            
        }

        public void MakeAnOrder(string starter, string main, string dessert)
        {
            AOrder = new Order(starter, main, dessert);
        }

        public void Arrives()
        {
            //Client arrives at the room
        }

        public void Eat()
        {
            IsServed = true;
            
            //Client is eating
            //Dish finished
        }

    }
}