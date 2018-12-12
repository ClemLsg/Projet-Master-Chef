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
                        //RoomClerk go to the table and serve bread on the table
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
                        //RoomClerk go to the table and serve water on the table
                        table.HasWater = true;
                    }
                }
            }
        }




    }
}
