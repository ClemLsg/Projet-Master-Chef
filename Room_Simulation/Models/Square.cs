using System.Collections.Generic;

namespace Room_Simulation.Models
{
    public class Square
    {
        //FIELDS
        public List<Table> Tables { get; set; }
        public List<Waiter> Waiters { get; set; }

        //CONSTRUCTOR
        public Square()
        {
            this.Tables = new List<Table>();
            this.Waiters = new List<Waiter>();
        }

        //METHODS
        public void AddTables(Table t)
        {
            this.Tables.Add(t);
        }

        public void AddWaiter(Waiter w)
        {
            this.Waiters.Add(w);
        }

        public void RemoveTables(Table t)
        {
            this.Tables.Remove(t);
        }

        public void RemoveWaiter(Waiter w)
        {
            this.Waiters.Remove(w);
        }
    }
}