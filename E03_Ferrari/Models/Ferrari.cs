namespace E03_Ferrari.Models
{
    public class Ferrari : ICar
    {
        public Ferrari(string driverName)
        {
            this.Driver = driverName.Trim();
            this.Model = "488-Spider";
        }

        public string Driver { get; }

        public string Model { get; }
        

        public string PushTheGasPedal()
        {
            return "Zadu6avam sA!";
        }

        public string UseBreaks()
        {
            return "Brakes!";
        }
    }
}