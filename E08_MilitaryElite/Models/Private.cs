using System;
using E08_MilitaryElite.Interfaces;

namespace E08_MilitaryElite.Models
{
    public class Private : Soldier, IPrivate
    {
        public Private(int id, string firstName, string lastName, double salary)
            :base(id, firstName, lastName)
        {
            this.Salary = salary;
        }
        public double Salary { get; private set; }

        public override string ToString()
        {
            return $"Name: {base.FirstName} {base.LastName} Id: {base.Id} Salary: {this.Salary :f2}";
        }
    }
}