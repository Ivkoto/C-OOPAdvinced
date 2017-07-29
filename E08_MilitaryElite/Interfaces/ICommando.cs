using System.Collections.Generic;

namespace E08_MilitaryElite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        IList<IMission> Missions { get; }

        void CompleteMission();
    }
}