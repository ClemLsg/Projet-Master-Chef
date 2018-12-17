namespace Room_Simulation.Models
{
    
    public class Table
    {
        public int IDTable { get; set; }
        public int Seats { get; set; }
        public bool HasBread { get; set; }
        public bool HasWater { get; set; }
        public TableStatus TableStatus { get; set; }
        public Square square { get; set; }

        public ClientGroup ClientsGroup { get; set; }
        
        public Table(int idtable, int place)
        {
            this.IDTable = idtable;
            this.Seats = place;
            this.TableStatus = TableStatus.Free;
        }
        public void AddClient(ClientGroup client)
        {
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