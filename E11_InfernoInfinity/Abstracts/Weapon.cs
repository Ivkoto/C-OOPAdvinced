using E11_InfernoInfinity.Enums;
using E11_InfernoInfinity.Interfaces;
using E11_InfernoInfinity.Models;
using E11_InfernoInfinity.Attributes;
using System.Collections.Generic;

namespace E11_InfernoInfinity.Abstracts
{
    [Cust("Pesho", 3, "Used for C# OOP Advanced Course - Enumerations and Attributes.", "Pesho", "Svetlio")]
    public abstract class Weapon : IWeapon
    {
        public Weapon(string name, RarityLevel rarityLevel, int minDamageInitialValue, int maxDamageInitialValue, int socketInitialNumber)
        {
            this.Name = name;
            this.BaseStat = new BaseStatus(minDamageInitialValue, maxDamageInitialValue, socketInitialNumber, rarityLevel);
            this.MagicalStat = new MagicalStatus();
            this.RarityLevel = rarityLevel;
        }

        public string Name { get; set; }

        public BaseStatus BaseStat { get; set; }

        public MagicalStatus MagicalStat { get; set; }

        public RarityLevel RarityLevel { get; set; }

        public void AddGem(int socketIndex, IGem gem)
        {
            if (socketIndex > this.BaseStat.Sockets.Length - 1)
            {
                return;
            }
            if (this.BaseStat.Sockets[socketIndex] != null)
            {
                RemoveGem(socketIndex);
            }
            this.BaseStat.Sockets[socketIndex] = gem;
            UpdateMagicalStatus(gem, "addGem");
        }

        public void UpdateMagicalStatus(IGem gem, string command)
        {
            this.MagicalStat.UpdateStatus(gem.StrengthBonus, gem.AgilityBonus, gem.VitalityBonus, command);
            UpdateBaseStatus(gem.StrengthBonus, gem.AgilityBonus, command);
        }

        public void UpdateBaseStatus(int strengthBonus, int agilityBonus, string command)
        {
            this.BaseStat.UpdateStatus(strengthBonus, agilityBonus, command);
        }

        public void RemoveGem(int socketIndex)
        {
            if (this.BaseStat.Sockets[socketIndex] == null || socketIndex > this.BaseStat.Sockets.Length - 1)
            {
                return;
            }
            UpdateMagicalStatus(this.BaseStat.Sockets[socketIndex], "removeGem");
        }
    }
}