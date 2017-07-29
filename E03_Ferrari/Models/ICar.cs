namespace E03_Ferrari.Models
{
    public interface ICar
    {
        string Model { get; }
        string Driver { get; }
        string UseBreaks();
        string PushTheGasPedal();
    }
}