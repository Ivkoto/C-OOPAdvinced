using E11_InfernoInfinity.Abstracts;
using E11_InfernoInfinity.Enums;

namespace E11_InfernoInfinity.Models
{
    public class Knife : Weapon
    {
        private const int minDamageInitialValue = 3;
        private const int maxDamageInitialValue = 4;
        private const int socketInitialNumber = 2;

        public Knife(string name, RarityLevel rarityLevel)
            : base(name, rarityLevel, minDamageInitialValue, maxDamageInitialValue, socketInitialNumber)
        {
        }
    }
}