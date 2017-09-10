using System;

namespace E05_ComparingObject
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public int CompareTo(Person otherPerson)
        {
            var nameCompare = this.Name.CompareTo(otherPerson.Name);
            if (nameCompare != 0)
            {
                return nameCompare;
            }

            var ageCompare = this.Age.CompareTo(otherPerson.Age);
            if (ageCompare != 0)
            {
                return ageCompare;
            }

            return this.Town.CompareTo(otherPerson.Town);
        }
    }
}