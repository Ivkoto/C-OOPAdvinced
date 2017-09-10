using System;
using System.Collections.Generic;

namespace E05_ComparingObject
{
    public class Program
    {
        public static void Main()
        {
            List<Person> persons = GetPeople();

            var nthPersonNumber = int.Parse(Console.ReadLine());

            if (nthPersonNumber < 0 || nthPersonNumber > persons.Count - 1)
            {
                Console.WriteLine("No matches");
                return;
            }

            var nthPerson = persons[nthPersonNumber];
            var equalCount = 0;
            var differentCount = 0;
            foreach (var per in persons)
            {
                if (per.CompareTo(nthPerson) == 0)
                {
                    equalCount++;
                }
                else
                {
                    differentCount++;
                }
            }          

            Console.WriteLine($"{equalCount} {differentCount} {persons.Count}");
        }

        private static List<Person> GetPeople()
        {
            var persons = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var args = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = args[0];
                var age = int.Parse(args[1]);
                var town = args[2];
                persons.Add(new Person(name, age, town));
            }

            return persons;
        }
    }
}