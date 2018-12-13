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
        Room_Simulation.Controlers.RoomController controller = new Room_Simulation.Controlers.RoomController();

        public HeadWaiter(Square square)
        {
            //Constructor
            //Headwaiter created
        }

        public void GiveMenu(Table table)
        {
            this.controller.Animation("Headwaiter give a menu to the client group");
            foreach (Client client in table.ClientsGroup.Clients)
            {

                this.controller.Animation("Client go to their table with HeadWaiter");

            }
            table.TableStatus = TableStatus.Choosing;
            
        }
        public Order TakeOrder(Client client)
        {
            controller.Animation("HeadWaiter go to the client table")
            return client.AOrder;
        }
        public Order BringOrder(Order order)
        {
            controller.Animation("HeadWaiter bring the order to the chef (bar)");
            return order;
        }
        public  void SwitchSquare(Square NewSquare)
        {
            this.square = NewSquare;
        }
    }
}

