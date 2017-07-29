using E07_FoodShortage.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace E07_FoodShortage
{
    public class Program
    {
        public static void Main()
        {
            ICollection<IBuyer> people = new HashSet<IBuyer>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var peopleArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (peopleArgs.Length == 4)
                {
                    var name = peopleArgs[0];
                    var age = int.Parse(peopleArgs[1]);
                    var id = peopleArgs[2];
                    var birthdate = peopleArgs[3];
                    var person = new Citizen(name, age, id, birthdate);
                    people.Add(person);
                }
                else if (peopleArgs.Length == 3)
                {
                    var name = peopleArgs[0];
                    var age = int.Parse(peopleArgs[1]);
                    var group = peopleArgs[2];
                    var person = new Rebel(name, age, group);
                    people.Add(person);
                }                
            }

            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var name = input.Trim();
                var currentPerson = people.Where(p => p.Name == name).FirstOrDefault();
                if (currentPerson != null)
                {
                    currentPerson.BuyFood();
                }                
            }

            Console.WriteLine(people.Sum(p => p.Food));
        }
    }
}