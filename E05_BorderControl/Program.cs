using E05_BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E05_BorderControl
{
    public class Program
    {
        public static void Main()
        {
            ICollection<IIdentifiable> townList = new List<IIdentifiable>();
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split(' ');
                if (tokens.Length == 2)
                {
                    var robot = new Robot(tokens[0], tokens[1]);
                    townList.Add(robot);
                }
                else
                {
                    var human = new Citizen(tokens[0], int.Parse(tokens[1]), tokens[2]);
                    townList.Add(human);

                }
                
            }
            var endOfFakeIds = Console.ReadLine();
            var fakeIdCitizens = townList.Where(c => c.Id.EndsWith(endOfFakeIds)).ToArray();
            foreach (var citizen in fakeIdCitizens)
            {
                Console.WriteLine(citizen.Id);
            }
        }
    }
}