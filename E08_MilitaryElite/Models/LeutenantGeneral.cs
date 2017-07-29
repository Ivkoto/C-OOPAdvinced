using System;
using System.Collections.Generic;
using E08_MilitaryElite.Interfaces;
using System.Text;

namespace E08_MilitaryElite.Models
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(int id, string firstName, string lastName, double salary)
            :base(id, firstName, lastName, salary)
        {
            this.Privates = new HashSet<Private>();
        }
        public HashSet<Private> Privates { get; private set; }

        public void AddPrivate(Private priv)
        {
            this.Privates.Add(priv);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {this.Salary :f2}")
              .AppendLine("Privates:");
            foreach (var @private in Privates)
            {
                sb.AppendLine($"  {@private.ToString()}");
            }

            return sb.ToString();
        }
    }
}