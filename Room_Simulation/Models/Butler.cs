using Room_Simulation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitchen_Simulation.Models
{
    class Butler
    {
        public Room Room { get; set; }
        public HeadWaiter AssignTable(ClientGroup clientGroup)
        {
            foreach (Square square in Room.Squares)
            {
                foreach (Table table in square.Tables)
                {
                    if (table.TableStatus == TableStatus.Free && table.Seats >= clientGroup.Clients.Count())

                    table.ClientsGroup = clientGroup;
                    foreach (Client client in table.ClientsGroup.Clients)
                    {

                        //Client go to table
                        return square.HeadWaiters;
                    }
                    break;
                    
                }
            }
            return null;
        }
    }
}
