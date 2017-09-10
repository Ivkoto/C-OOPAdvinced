using E08_PetClinics.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E08_PetClinics
{
    public class CommandExecutor
    {
        private string command;
        private string[] commandArgs;

        public CommandExecutor(string command, string[] commandArgs)
        {
            this.command = command;
            this.commandArgs = commandArgs;
        }

        public void ExecuteCommand(List<Pet> pets, List<Clinic> clinics)
        {
            switch (this.command)
            {
                case "Create":
                    CreateEntity(commandArgs, pets, clinics);
                    break;

                case "Add":
                    var petName = commandArgs[0];
                    var clinicName = commandArgs[1];
                    Console.WriteLine(AddPetToClinic(petName, clinicName, pets, clinics));
                    break;

                case "Release":
                    Console.WriteLine(ReleasePetFromClinic(commandArgs[0], clinics));
                    break;

                case "HasEmptyRooms":

                    break;

                case "Print":

                    break;
            }
        }

        private bool ReleasePetFromClinic(string clinicName, List<Clinic> clinics)
        {
            clinics.Where(c => c.Name == clinicName).First().TryRelesePet();
        }

        private bool AddPetToClinic(string petName, string clinicName, List<Pet> pets, List<Clinic> clinics)
        {
            var currentPet = pets.Where(p=> p.Name == petName).First();            
            bool success = clinics.Where(c => c.Name == clinicName).First().TryAddPet(currentPet);
            if (success)
            {                
                pets.Remove(currentPet);
                return true;
            }

            return false;
        }

        private void CreateEntity(string[] commandArgs, List<Pet> pets, List<Clinic> clinics)
        {
            if (commandArgs[0] == "Pet")
            {
                var name = commandArgs[1];
                var age = int.Parse(commandArgs[2]);
                var kind = commandArgs[3];
                pets.Add(new Pet(name, age, kind));
            }
            else if (commandArgs[0] == "Clinic")
            {
                var name = commandArgs[1];
                var roomsCount = int.Parse(commandArgs[2]);
                try
                {
                    clinics.Add(new Clinic(name, roomsCount));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
                
            }
        }
    }
}