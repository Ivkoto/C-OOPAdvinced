using System.Collections.Generic;
using System.Linq;

namespace E06_StrategyPattern
{
    public class NameComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            var nameCompare = x.Name.Length - y.Name.Length;
            if (nameCompare == 0)
            {
                char xFirstLetter = char.ToLower(x.Name[0]);
                char yFirstLetter = char.ToLower(y.Name[0]);
                nameCompare = xFirstLetter.CompareTo(yFirstLetter);
            }

            return nameCompare;
        }
    }
}