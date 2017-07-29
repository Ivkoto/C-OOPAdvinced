using System.Collections.Generic;

namespace E08_MilitaryElite.Interfaces
{
    public interface IEngineer : ISpecialisedSoldier
    {
        IList<IRepair> Parts { get; }
    }
}