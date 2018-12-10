namespace Room_Simulation.Models
{
    public class Table
    {
        private ClientGroup clients;
        public int iDTable { get; set; }
        public int seats { get; set; }
        public bool hasBread { get; set; }
        public bool hasWater { get; set; }

        public ClientGroup GetClients()
        {
            return this.clients;
        }
        public void AddClient(Client client)
        {
            clients.Clients.Add(client);
        }
    }
}