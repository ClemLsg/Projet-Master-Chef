using Room_Simulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Models
{
    public class HeadWaiter
    {
        public Square square;
        Room_Simulation.Controlers.RoomController controller = new Room_Simulation.Controlers.RoomController();
        public int HeadWaiterID { get; set; }
        public HeadWaiter(Square square)
        {
            //Constructor
            //Headwaiter created
        }

        public void GiveMenu(Table table)
        {
            this.controller.Animation("GiveMenu " + table.IDTable.ToString()); // Wich table ? TODO
            foreach (Client client in table.ClientsGroup.Clients)
            {

                this.controller.Animation("ClientGoTable " + table.IDTable.ToString()); // Wich table ? TODO

            }
            table.TableStatus = TableStatus.Choosing;
            
        }
        public Order TakeOrder(Client client, Table table)
        {
            controller.Animation("HeadGoToTable " + table.square.HeadWaiters.HeadWaiterID.ToString() + "TO " + table.IDTable.ToString()); // Wich headwaiter ? Wich Table ? TODO
            return client.AOrder;
        }
        public Order BringOrder(Client client, Table table)
        {
            controller.Animation("HeadGoToExchange " + table.square.HeadWaiters.HeadWaiterID.ToString()); // Wich Headwaiter ? TODO
            return client.AOrder;
        }
        public  void SwitchSquare(Square NewSquare)
        {
            this.square = NewSquare;
        }
    }
}

