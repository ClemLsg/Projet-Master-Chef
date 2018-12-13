using Room_Simulation.Models;



namespace Room_Simulation.Models
{
    public class Waiter
    {
        public Square square;
        Room_Simulation.Controlers.RoomController controller = new Room_Simulation.Controlers.RoomController();


        public Waiter(Square square)
        {
            //Constructor
        }
        public void ServeOrder(ClientGroup clientGroup)
        {
            controller.Animation("the waiter go to the table and serve the starter, main and dessert to everyone");
            clientGroup.table.TableStatus = TableStatus.Eating;

        }
        public void CLeanTable (Table table)
        {
            controller.Animation("The Waiter clean the table");
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