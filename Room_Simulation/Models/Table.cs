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
        
        public Table(int place)
        {
            this.Seats = place;
            this.TableStatus = TableStatus.Free;
        }
        public void AddClient(ClientGroup client)
        {
            //The HeadWaiter bring the client to the table
            this.ClientsGroup = client;
        }
        public void RemoveClient (Client client)
        {
            this.TableStatus = TableStatus.Free;
        }
        public ClientGroup GetClient()
        {
            return this.ClientsGroup;
        }

        public void IsDirty()
        {
            TableStatus = TableStatus.Dirty;
        }
    }

}