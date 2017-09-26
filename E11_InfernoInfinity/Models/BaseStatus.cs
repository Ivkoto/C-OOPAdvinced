using E11_InfernoInfinity.Enums;
using E11_InfernoInfinity.Interfaces;

namespace E11_InfernoInfinity.Models
{
    public class BaseStatus
    {
        private const int StrengthPointBunusMinDamage = 2;
        private const int StrengthPointBunusMaxDamage = 3;
        private const int AgilityPointBonusMinDamage = 1;
        private const int AgilityPointBonusMaxDamage = 4;

        public BaseStatus(int minDamage, int maxDamage, int sockets, RarityLevel rarityLevel)
        {
            this.MinDamage = minDamage * (int)rarityLevel;
            this.MaxDamage = maxDamage * (int)rarityLevel;
            this.Sockets = new IGem[sockets];
        }

        public int MinDamage { get; private set; }
        
        public int MaxDamage { get; private set; }
        
        public IGem[] Sockets { get; private set; }

        public void UpdateStatus(int strengthBonus, int agilityBonus, string command)
        {
            if (command == "addGem")
            {
                this.MinDamage += strengthBonus * StrengthPointBunusMinDamage;
                this.MinDamage += agilityBonus * AgilityPointBonusMinDamage;
                this.MaxDamage += strengthBonus * StrengthPointBunusMaxDamage;
                this.MaxDamage += agilityBonus * AgilityPointBonusMaxDamage;
            }
            else if (command == "removeGem")
            {
                this.MinDamage -= strengthBonus * StrengthPointBunusMinDamage;
                this.MinDamage -= agilityBonus * AgilityPointBonusMinDamage;
                this.MaxDamage -= strengthBonus * StrengthPointBunusMaxDamage;
                this.MaxDamage -= agilityBonus * AgilityPointBonusMaxDamage;
            }
            
        }
    }
}