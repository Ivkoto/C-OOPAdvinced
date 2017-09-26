using E11_InfernoInfinity.Abstracts;
using E11_InfernoInfinity.Enums;

namespace E11_InfernoInfinity.Models
{
    public class Amethyst : Gem
    {
        private const int strengthBonus = 2;
        private const int agilityBonus = 8;
        private const int vitalityBonus = 4;

        public Amethyst(ClarityLevel clarity)
            : base(clarity, strengthBonus, agilityBonus, vitalityBonus)
        {
        }
    }
}