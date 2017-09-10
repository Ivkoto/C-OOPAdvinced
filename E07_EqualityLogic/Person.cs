using System;
using System.Collections.Generic;

namespace E07_EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int CompareTo(Person other)
        {
            var compare = this.Name.CompareTo(other.Name);
            return compare == 0 ? this.Age - other.Age : compare;
        }        
    }
}