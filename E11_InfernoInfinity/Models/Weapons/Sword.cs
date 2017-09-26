using E11_InfernoInfinity.Enums;
using E11_InfernoInfinity.Interfaces;
using E11_InfernoInfinity.Abstracts;


namespace E11_InfernoInfinity.Models
{
    public class Sword : Weapon
    {
        private const int minDamageInitialValue = 4;
        private const int maxDamageInitialValue = 6;
        private const int socketInitialNumber = 3;

        public Sword(string name, RarityLevel rarityLevel)
            :base(name, rarityLevel, minDamageInitialValue, maxDamageInitialValue, socketInitialNumber)
        {
        }
    }
}