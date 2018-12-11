namespace Room_Simulation.Models
{
    
    public class Table
    {
        public int IDTable { get; set; }
        public int Seats { get; set; }
        public bool HasBread { get; set; }
        public bool HasWater { get; set; }
        public TableStatus TableStatus { get; set; }

        public ClientGroup ClientsGroup { get; set; }
    }

}