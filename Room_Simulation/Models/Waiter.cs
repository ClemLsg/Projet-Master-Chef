using Room_Simulation.Models;
using Kitchen_Simulation;



namespace Room_Simulation.Models
{
    public class Waiter
    {
        public Square square;

        public Waiter(Square square)
        {
            //Constructor
        }
        public void ServeOrder(ClientGroup clientGroup)
        {
            // the waiter go to the table and serve the starter, main and dessert to everyone
            clientGroup.table.TableStatus = TableStatus.Eating;
        }
        public void CLeanTable (Table table)
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