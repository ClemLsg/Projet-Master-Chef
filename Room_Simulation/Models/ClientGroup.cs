using System.Collections.Generic;

namespace Room_Simulation.Models
{
    public class ClientGroup
    {
        public List<Client> Clients { get; set; }
        public int TimeToEatStarter { get; set; }
        public int TimeToEatMain { get; set; }
        public int TimeToEatDessert { get; set; }
        public Table table { get; set; }

        public bool Seated { get; set; }
        
        public ClientGroup(List<Client> clients, int timeToEatStarter, int timeToEatMain, int timeToEatDessert)
        {
            this.Clients = clients;
            this.TimeToEatStarter = timeToEatStarter;
            this.TimeToEatMain = timeToEatMain;
            this.TimeToEatDessert = timeToEatDessert;
        }
    }
}