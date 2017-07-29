using System;
using E08_MilitaryElite.Interfaces;

namespace E08_MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.Name = partName;
            this.Hours = hoursWorked;
        }
        public string Name { get; private set; }

        public int Hours { get; private set; }

        public override string ToString()
        {
            return $"Part Name: {this.Name} Hours Worked: {this.Hours}";
        }
    }
}