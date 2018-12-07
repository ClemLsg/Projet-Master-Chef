namespace Room_Simulation.Models
{
    public class Waiter
    {
        //FIELDS
        private Square Square;

        //CONSTRUCTOR
        public Waiter(Square s)
        {
            this.SetSquare(s);
        }

        //METHODS
        public Square GetSquare()
        {
            return Square;
        }

        public void SetSquare(Square value)
        {
            Square = value;
        }

        public void BringOrder(Order o)
        {

        }

        public void CleanTable(Table t)
        {
            t.SetIsCleaned(true);
        }

        public void SwitchSquare(Square s)
        {
            this.SetSquare(s);
        }
    }
}