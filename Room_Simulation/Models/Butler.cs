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
            bool freetable = false;
            foreach (Square square in Room.Squares)
            {
                foreach (Table table in square.Tables)
                {
                    if (table.TableStatus == TableStatus.Free && table.Seats >= clientGroup.Clients.Count())
                    { //Client go to table
                        freetable = true;
                        clientGroup.table = table;
                        table.ClientsGroup = clientGroup;
                        HeadWaiter headWaiter = square.HeadWaiters;
                        return headWaiter;
                    }
                    
                }
            }

            if (freetable == false)
            {
                //Client leave the room
            }
            return null;
        }
    }
}
