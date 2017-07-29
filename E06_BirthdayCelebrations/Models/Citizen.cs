using System;

namespace E06_BirthdayCelebrations.Models
{
    public class Citizen : IBirthable
    {
        public Citizen(string name, int age, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Birthdate = birthdate;
        }

        public string Birthdate { get; private set; }

        public string Name { get; private set; }
        private int Age { get; set; }
    }
}