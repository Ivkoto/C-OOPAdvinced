using E11_InfernoInfinity.Enums;

namespace E11_InfernoInfinity.Interfaces
{
    public interface IGem
    {
        int StrengthBonus { get; }

        int AgilityBonus { get; }

        int VitalityBonus { get; }

        ClarityLevel Clarity { get; }
    }
}