using Room_Simulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Models
{
    public class HeadWaiter
    {
        public Square square;

        public HeadWaiter(Square square)
        {
            //Constructor
            //Headwaiter created
        }

        public void GiveMenu()
        {
            //Headwaiter give a menu to the client group
        }
        public Order TakeOrder(Client client)
        {
            //On the IHM Give men to CLient
            return client.AOrder;
        }
        public Order BringOrder(Order order)
        {
            //On the IHM the HeadWaiter bring the order to the chef
            return order;
        }
        public  void SwitchSquare(Square NewSquare)
        {
            this.square = NewSquare;
        }
    }
}

