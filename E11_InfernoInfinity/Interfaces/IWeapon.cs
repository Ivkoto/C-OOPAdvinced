using E11_InfernoInfinity.Enums;
using E11_InfernoInfinity.Models;

namespace E11_InfernoInfinity.Interfaces
{
    public interface IWeapon
    {
        string Name { get; }

        BaseStatus BaseStat { get; }

        MagicalStatus MagicalStat { get; }

        RarityLevel RarityLevel { get; }
    }
}