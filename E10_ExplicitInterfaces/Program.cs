using System;

namespace E10_ExplicitInterfaces
{
    using E10_ExplicitInterfaces.Models;
    using E10_ExplicitInterfaces.Interfaces;

    public class Program
    {
        public static void Main()
        {
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                var personArgs = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                IPerson citizenP = new Citizen(personArgs[0], personArgs[1], int.Parse(personArgs[2]));
                IResident citizenR = new Citizen(personArgs[0], personArgs[1], int.Parse(personArgs[2]));

                Console.WriteLine(citizenP.GetName());
                Console.WriteLine(citizenR.GetName());
            }

        }
    }
}