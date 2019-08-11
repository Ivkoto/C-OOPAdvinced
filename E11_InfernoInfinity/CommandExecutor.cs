using E11_InfernoInfinity.Abstracts;
using E11_InfernoInfinity.Attributes;
using E11_InfernoInfinity.Enums;
using E11_InfernoInfinity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E11_InfernoInfinity
{
    public class CommandExecutor
    {
        private string command;
        private string[] commandArgs;
        private List<Weapon> weapons;

        public CommandExecutor(string command, string[] commandArgs, List<Weapon> weapons)
        {
            this.command = command;
            this.commandArgs = commandArgs;
            this.weapons = weapons;
        }

        public void ExecuteCommand()
        {
            switch (this.command)
            {
                case "Create":
                    CreateWeapon();
                    break;

                case "Add":
                    AddGem();
                    break;

                case "Remove":
                    RemoveGem();
                    break;

                case "Print":
                    PrintWeaponDetails();
                    break;

                case "Author":
                    var attrib = ExtractingAttributeValues();
                    Console.WriteLine($"Author: {attrib.Author.ToString()}");
                    break;

                case "Revision":
                    attrib = ExtractingAttributeValues();
                    Console.WriteLine($"Revision: {attrib.Revision.ToString()}");
                    break;

                case "Description":
                    attrib = ExtractingAttributeValues();
                    Console.WriteLine($"Class description: {attrib.Description.ToString()}");
                    break;

                case "Reviewers":
                    attrib = ExtractingAttributeValues();
                    var reviewers = string.Join(", ", attrib.Reviewers);
                    Console.WriteLine($"Reviewers: {reviewers}");
                    break;
            }
        }

        private CustAttribute ExtractingAttributeValues()
        {
            var attr = (CustAttribute)typeof(Weapon).GetCustomAttributes(false).First();
            return attr;
        }

        private void PrintWeaponDetails()
        {
            var weaponName = this.commandArgs[0];
            var currWeapon = this.weapons.Where(w => w.Name == weaponName).First();
            Console.WriteLine($"{currWeapon.Name}: {currWeapon.BaseStat.MinDamage}-{currWeapon.BaseStat.MaxDamage} Damage, " +
                $"+{currWeapon.MagicalStat.Strength} Strength, +{currWeapon.MagicalStat.Agility} Agility, " +
                $"+{currWeapon.MagicalStat.Vitality} Vitality");
        }

        private void RemoveGem()
        {
            var weaponName = this.commandArgs[0];
            var socketIndex = int.Parse(this.commandArgs[1]);
            this.weapons.Where(w => w.Name == weaponName).First().RemoveGem(socketIndex);
        }

        private void AddGem()
        {
            var weaponName = this.commandArgs[0];
            var socketIndex = int.Parse(commandArgs[1]);
            var gemType = commandArgs[2].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var clarityLevel = (ClarityLevel)Enum.Parse(typeof(ClarityLevel), gemType[0]);
            var gemKynd = gemType[1];
            Gem gem;

            if (gemKynd == "Ruby")
            {
                gem = new Ruby(clarityLevel);
            }
            else if (gemKynd == "Emerald")
            {
                gem = new Emerald(clarityLevel);
            }
            else
            {
                gem = new Amethyst(clarityLevel);
            }

            this.weapons.Where(w => w.Name == weaponName).First().AddGem(socketIndex, gem);
        }

        private void CreateWeapon()
        {
            var weaponType = commandArgs[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var weaponName = commandArgs[1];
            var weaponKind = weaponType[1];
            var rarityLevel = (RarityLevel)Enum.Parse(typeof(RarityLevel), weaponType[0]);
            Weapon weapon;
            if (weaponKind == "Axe")
            {
                weapon = new Axe(weaponName, rarityLevel);
            }
            else if (weaponKind == "Sword")
            {
                weapon = new Sword(weaponName, rarityLevel);
            }
            else
            {
                weapon = new Knife(weaponName, rarityLevel);
            }
            this.weapons.Add(weapon);
        }
    }
}