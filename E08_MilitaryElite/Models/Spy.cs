using System;
using E08_MilitaryElite.Interfaces;
using System.Text;

namespace E08_MilitaryElite.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; private set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Name: {base.FirstName} {base.LastName} Id: {base.Id}")
              .Append($"Code Number: {this.CodeNumber}");

            return sb.ToString();
        }
    }
}