namespace Kitchen_Simulation
{
    public class Sleeper
    {
        public int Interval { get; set; } = 60;
        public bool IsPaused { get; set; } = false;
        public int TimeElapsed { get; set; } = 0;
        public int Period => 1000 / Interval;
    }
}