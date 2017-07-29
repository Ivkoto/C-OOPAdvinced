using System.Collections.Generic;

namespace E08_MilitaryElite.Interfaces
{
    public interface ICommando
    {
        HashSet<IMission> Missions { get; }
    }
}