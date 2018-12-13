using Room_Simulation.Models;
using Kitchen_Simulation;



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
            controller.Animation("WaiterServe"); // table ? TODO
            clientGroup.table.TableStatus = TableStatus.Eating;
        }
        public void CLeanTable (Table table)
        {
            controller.Animation("WaiterClean" + table.IDTable.ToString()); // TABLE ? TODO
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