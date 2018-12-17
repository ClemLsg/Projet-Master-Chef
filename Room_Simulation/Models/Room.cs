using System;
using System.Collections.Generic;

namespace Room_Simulation.Models
{

    public class Room
    {
        //FIELDS
        public List<Square> Squares { get; set; }

        //CONSTRUCTOR
        public Room()
        {
            this.Squares = new List<Square>();
        }

        //METHODS
        public void AddSquare(Square s)
        {
            this.Squares.Add(s);
        }

        public void RemoveSquare(Square s)
        {
            this.Squares.Remove(s);
        }
    }
}