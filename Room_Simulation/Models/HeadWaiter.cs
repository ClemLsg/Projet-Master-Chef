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
            this.controller.Animation("GiveMenu"); // Wich table ? TODO
            foreach (Client client in table.ClientsGroup.Clients)
            {

                this.controller.Animation("ClientGoTable"); // Wich table ? TODO

            }
            table.TableStatus = TableStatus.Choosing;
            
        }
        public Order TakeOrder(Client client)
        {
            controller.Animation("HeadGoToTable"); // Wich headwaiter ? Wich Table ? TODO
            return client.AOrder;
        }
        public Order BringOrder(Order order)
        {
            controller.Animation("HeadGoToExchange"); // Wich Headwaiter ? TODO
            return order;
        }
        public  void SwitchSquare(Square NewSquare)
        {
            this.square = NewSquare;
        }
    }
}

