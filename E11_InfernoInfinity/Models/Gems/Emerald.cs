using E11_InfernoInfinity.Abstracts;
using E11_InfernoInfinity.Enums;

namespace E11_InfernoInfinity.Models
{
    public class Emerald : Gem
    {
        private const int strengthBonus = 1;
        private const int agilityBonus = 4;
        private const int vitalityBonus = 9;

        public Emerald(ClarityLevel clarity)
            : base(clarity, strengthBonus, agilityBonus, vitalityBonus)
        {
        }
    }
}