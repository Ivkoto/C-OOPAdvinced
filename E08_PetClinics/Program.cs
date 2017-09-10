using E08_PetClinics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E08_PetClinics
{
    public class Program
    {
        public static void Main()
        {
            var pets = new List<Pet>();
            var clinics = new List<Clinic>();
            var commandCount = int.Parse(Console.ReadLine());
            string[] commandArgs;
            for (int i = 0; i < commandCount; i++)
            {
                commandArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var command = commandArgs[0];
                var commandExecutor = new CommandExecutor(command, commandArgs.Skip(1).ToArray());
                commandExecutor.ExecuteCommand(pets, clinics);
            }
        }
    }
}