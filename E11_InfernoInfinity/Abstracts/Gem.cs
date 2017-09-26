using E11_InfernoInfinity.Enums;
using E11_InfernoInfinity.Interfaces;

namespace E11_InfernoInfinity.Abstracts
{
    public abstract class Gem : IGem
    {
        public Gem(ClarityLevel clarity, int strengthBonus, int agilityBonus, int vitalityBonus)
        {
            this.Clarity = clarity;
            this.StrengthBonus = strengthBonus + (int)clarity;
            this.AgilityBonus = agilityBonus + (int)clarity;
            this.VitalityBonus = vitalityBonus + (int)clarity;
        }

        public int StrengthBonus { get; set; }

        public int AgilityBonus { get; set; }

        public int VitalityBonus { get; set; }

        public ClarityLevel Clarity { get; set; }
    }
}