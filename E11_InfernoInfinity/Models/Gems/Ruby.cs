using E11_InfernoInfinity.Abstracts;
using E11_InfernoInfinity.Enums;

namespace E11_InfernoInfinity.Models
{
    public class Ruby : Gem
    {
        private const int strengthBonus = 7;
        private const int agilityBonus = 2;
        private const int vitalityBonus = 5;

        public Ruby(ClarityLevel clarity)
            : base(clarity, strengthBonus, agilityBonus, vitalityBonus)
        {
        }        
    }
}