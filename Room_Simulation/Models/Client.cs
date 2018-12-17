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
            this.controlers.Animation("ClientGoToEx"); // TODO WICH CLIENT ? TODO
            this.controlers.Animation("ClientPay"); // WIIIIIICH CLIENT ? TODO
            this.controlers.Animation("ClientLeave"); // WIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIIICH ???????????????????????????? TODO

        }

        public void MakeAnOrder(string starter, string main, string dessert)
        {
            AOrder = new Order(starter, main, dessert);
        }

        public void Arrives()
        {
            this.controlers.Animation("ClientSpawn"); // Give me the client id please TODO
        }

        public void Eat()
        {
            IsServed = true;

            this.controlers.Animation("ClientEat"); // WIIIIIICH TODO

            this.controlers.Animation("ClientFinishEat"); // WIIIIICH TODO
        }

    }
}