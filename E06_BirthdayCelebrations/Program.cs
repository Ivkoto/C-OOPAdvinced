using E06_BirthdayCelebrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E06_BirthdayCelebrations
{
    public class Program
    {
        public static void Main()
        {
            ICollection<IBirthable> townList = new List<IBirthable>();
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(' ');
                if (tokens[0].Equals("Citizen"))
                {
                    var human = new Citizen(tokens[1], int.Parse(tokens[2]), tokens[4]);
                    townList.Add(human);
                }
                else if (tokens[0].Equals("Pet"))
                {
                    var pet = new Pet(tokens[1], tokens[2]);
                    townList.Add(pet);
                }
            }
            var serchDate = Console.ReadLine();
            var citizensBornOnSerchedDate = townList.Where(c => c.Birthdate.EndsWith(serchDate)).ToArray();
            foreach (var citizen in citizensBornOnSerchedDate)
            {
                Console.WriteLine(citizen.Birthdate);
            }
        }
    }
}