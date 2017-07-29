using System.Collections.Generic;

namespace E08_MilitaryElite.Interfaces
{
    public interface IEngineer
    {
        HashSet<IRepair> Repairs { get; }
    }
}