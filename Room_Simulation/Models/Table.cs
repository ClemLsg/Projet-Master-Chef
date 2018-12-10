namespace Room_Simulation.Models
{
    
    public class Table
    {

        //FIELDS
        private int IDTable;
        private int Seats;
        private bool HasBread;
        private bool HasWater;
        private bool IsCleaned;
        ClientGroup Clients;

        //CONSTRUCTOR
        public Table(int place)
        {
            this.SetSeats(place);
        }

        //METHODS
        public int GetIDTable()
        {
            return this.IDTable;
        }

        public void SetIDTable(int value)
        {
            this.IDTable = value;
        }

        public int GetSeats()
        {
            return Seats;
        }

        public void SetSeats(int value)
        {
            Seats = value;
        }

        public bool GetIsCleaned()
        {
            return IsCleaned;
        }

        public void SetIsCleaned(bool value)
        {
            IsCleaned = value;
        }
        public ClientGroup GetClients()
        {
            return Clients;
        }
        public void SetClients (ClientGroup value)
        {
            Clients = value;
        }
    }   


}