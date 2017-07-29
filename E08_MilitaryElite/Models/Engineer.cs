using System;
using System.Collections.Generic;
using E08_MilitaryElite.Interfaces;
using System.Text;

namespace E08_MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, double salary, string corp) 
            : base(id, firstName, lastName, salary, corp)
        {
            this.Repairs = new HashSet<IRepair>();
        }

        public HashSet<IRepair> Repairs { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {this.Salary :f2}")
              .AppendLine($"Corps: {base.Corp}")
              .AppendLine("Repairs:");
            foreach (var repair in Repairs)
            {
                sb.AppendLine($"  {repair.ToString()}");
            }

            return sb.ToString();
        }
    }
}