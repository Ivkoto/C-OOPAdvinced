using System;

using E08_MilitaryElite.Interfaces;

namespace E08_MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corp;

        public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corp)
            : base(id, firstName, lastName, salary)
        {
            this.Corp = corp;
        }

        public string Corp { get; private set; }

        public override string ToString()
        {
            return $"{base.ToString()}" + Environment.NewLine + $"Corps: {this.Corp}";
        }
    }
}