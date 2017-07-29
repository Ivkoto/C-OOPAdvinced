namespace E08_MilitaryElite.Interfaces
{
    public interface IMission
    {
        string Name { get; }
        string State { get; }

        void CompleteMission();
    }
}