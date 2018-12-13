namespace Room_Simulation.Models
{
    public class Client
    {
        public bool IsServed { get; set; }
        public Order AOrder { get; set; }
        Controlers.RoomController controlers = new Controlers.RoomController();
        public Client()
        {

        }

        public void Pay()
        {
            this.controlers.Animation("Client go to bar");
            this.controlers.Animation("Client pay");
            this.controlers.Animation("Client leave the room");

        }

        public void MakeAnOrder(string starter, string main, string dessert)
        {
            AOrder = new Order(starter, main, dessert);
        }

        public void Arrives()
        {
            this.controlers.Animation("Arrives at room");
        }

        public void Eat()
        {
            IsServed = true;

            this.controlers.Animation("Client is eating");
            this.controlers.Animation("Dish finished");
        }

    }
}