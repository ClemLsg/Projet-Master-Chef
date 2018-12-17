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

        Room_Simulation.Controlers.RoomController controlers = new Room_Simulation.Controlers.RoomController();
        public HeadWaiter AssignTable(ClientGroup clientGroup, Table _table)
        {
            bool freetable = false;
            foreach (Square square in Room.Squares)
            {
                foreach (Table table in square.Tables)
                {
                    if (table.TableStatus == TableStatus.Free && table.Seats >= clientGroup.Clients.Count())
                    {
                        this.controlers.Animation("ClientGoTo " + _table.IDTable.ToString()); // wich table ? TODO
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
                this.controlers.Animation("ClientsLeave " + clientGroup.ClientGroupID.ToString()); // wich client ? TODO
            }
            return null;
        }
    }
}
