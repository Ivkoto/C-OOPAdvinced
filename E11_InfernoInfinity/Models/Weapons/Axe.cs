using E11_InfernoInfinity.Abstracts;
using E11_InfernoInfinity.Enums;
using E11_InfernoInfinity.Interfaces;

namespace E11_InfernoInfinity.Models
{
    public class Axe : Weapon
    {
        private const int minDamageInitialValue = 5;
        private const int maxDamageInitialValue = 10;
        private const int socketInitialNumber = 4;

        public Axe(string name, RarityLevel rarityLevel)
            : base(name, rarityLevel, minDamageInitialValue, maxDamageInitialValue, socketInitialNumber)
        {
        }
    }
}