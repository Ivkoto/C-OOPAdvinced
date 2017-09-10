using System;
using System.Collections.Generic;

namespace E07_EqualityLogic
{
    public class Program
    {
        public static void Main()
        {
            var sortedPeoples = new SortedSet<Person>();
            var hashedPeoples = new HashSet<Person>(new PersonComparer());

            FilledCollections(sortedPeoples, hashedPeoples);

            Console.WriteLine(sortedPeoples.Count);
            Console.WriteLine(hashedPeoples.Count);
        }

        private static void FilledCollections(SortedSet<Person> sortedPeoples, HashSet<Person> hashedPeoples)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var personArgs = Console.ReadLine().Split(' ');
                var person = new Person(personArgs[0], int.Parse(personArgs[1]));
                sortedPeoples.Add(person);
                hashedPeoples.Add(person);
            }
        }
    }
}