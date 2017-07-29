using System;
using System.Collections.Generic;
using E08_MilitaryElite.Interfaces;
using System.Text;

namespace E08_MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, double salary, string corp) 
            : base(id, firstName, lastName, salary, corp)
        {
            this.Missions = new HashSet<IMission>();
        }

        public HashSet<IMission> Missions { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {this.Salary :f2}")
              .AppendLine($"Corps: {base.Corp}")
              .AppendLine("Missions:");
            foreach (var mision in Missions)
            {
                sb.AppendLine($"  {mision.ToString()}");
            }
            return sb.ToString();
        }
    }
}