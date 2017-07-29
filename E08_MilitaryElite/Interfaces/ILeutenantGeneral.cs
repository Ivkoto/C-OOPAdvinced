using E08_MilitaryElite.Models;
using System.Collections.Generic;

namespace E08_MilitaryElite.Interfaces
{
    public interface ILeutenantGeneral
    {
        HashSet<Private> Privates { get; }
    }
}