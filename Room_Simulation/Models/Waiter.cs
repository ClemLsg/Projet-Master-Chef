using Room_Simulation.Models;



namespace Room_Simulation.Models
{
    public class Waiter
    {
        public Square square;

        public Waiter(Square square)
        {
            //Constructor
        }
        public static void ServeOrder(Table table)
        {
            // the waiter go to the table and serve the plate just cooked to client
            table.TableStatus = TableStatus.Eating;

        }
        public static void CLeanTable (Table table)
        {
            // THe Waiter clean the table
            if(table.TableStatus == TableStatus.Dirty)
            {
                table.TableStatus = TableStatus.Cleaned;
            }
        }
        public void SwitchSquare(Square NewSquare)
        {
            this.square = NewSquare;
        }
    }
}