namespace E11_InfernoInfinity.Models
{
    public class MagicalStatus
    {
        private const int defaultMagicalValue = 0;

        public MagicalStatus()
        {
            this.Strength = defaultMagicalValue;
            this.Agility = defaultMagicalValue;
            this.Vitality = defaultMagicalValue;
        }

        public int Strength { get; private set; }

        public int Agility { get;  private set; }

        public int Vitality { get;  private set; }

        public void UpdateStatus(int strengthBunus, int agilityBonus, int vitalityBonus, string command)
        {
            if (command == "addGem")
            {
                this.Strength += strengthBunus;
                this.Agility += agilityBonus;
                this.Vitality += vitalityBonus;
            }
            else if (command == "removeGem")
            {
                this.Strength -= strengthBunus;
                this.Agility -= agilityBonus;
                this.Vitality -= vitalityBonus;
            }            
        }
    }
}