using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Simulation.Models
{

    class RoomClerk
    {
        public List<Square> Squares { get; set; }
        public static RoomClerk UniqueInstance { get; set; }
        Room_Simulation.Controlers.RoomController controller = new Room_Simulation.Controlers.RoomController();

        public RoomClerk(List<Square> squares)
        {
            this.Squares = squares;
        }

        public void serveBread()
        {
            foreach (Square square in Squares)
            {
                foreach (Table table in square.Tables)
                {
                    if (!table.HasBread)
                    {
                        controller.Animation("ClerkGoToTableBread"); // Wich table ? TODO
                        table.HasBread = true;
                    }
                }
            }

        }

        public void serveDrink()
        {
            foreach (Square square in Squares)
            {
                foreach (Table table in square.Tables)
                {
                    if (!table.HasWater)
                    {
                        controller.Animation("ClerkGoToTableWater " + table.IDTable.ToString()); // Wich table ? TODO
                        table.HasWater = true;
                    }
                }
            }
        }




    }
}
