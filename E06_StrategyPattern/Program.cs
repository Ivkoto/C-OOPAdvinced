using System;
using System.Collections.Generic;

namespace E06_StrategyPattern
{
    public class Program
    {
        public static void Main()
        {
            var peopleByName = new SortedSet<Person>(new NameComparator());
            var peopleByAge = new SortedSet<Person>(new AgeComparator());

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var personArgs = Console.ReadLine().Split(' ');
                var person = new Person(personArgs[0], int.Parse(personArgs[1]));
                peopleByName.Add(person);
                peopleByAge.Add(person);
            }
            foreach (var pers in peopleByName)
            {
                Console.WriteLine(pers);
            }
            foreach (var pers in peopleByAge)
            {
                Console.WriteLine(pers);
            }
        }
    }
}