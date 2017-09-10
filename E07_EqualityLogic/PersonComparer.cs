using System.Collections.Generic;

namespace E07_EqualityLogic
{
    internal class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            return x.CompareTo(y) == 0;
        }

        public int GetHashCode(Person pers)
        {
            return $"{pers.Name} {pers.Age}".GetHashCode();
        }
    }
}