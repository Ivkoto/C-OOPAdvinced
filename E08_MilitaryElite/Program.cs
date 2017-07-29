using E08_MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E08_MilitaryElite
{
    public class Program
    {
        public static void Main()
        {
            var soldierInfo = string.Empty;
            var privateSoldiers = new List<Private>();
            while ((soldierInfo = Console.ReadLine().Trim()) != "End")
            {
                var soldierArgs = soldierInfo.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (soldierArgs[0])
                {
                    case "Private":
                        CreatePrivate(soldierArgs, privateSoldiers);
                        break;

                    case "LeutenantGeneral":
                        CreateLeutenantGeneral(soldierArgs, privateSoldiers);
                        break;

                    case "Engineer":
                        CreateEngineer(soldierArgs);
                        break;

                    case "Commando":
                        CretaeCommando(soldierArgs);
                        break;

                    case "Spy":
                        CreateSpy(soldierArgs);
                        break;
                }
            }
        }

        private static void CreateSpy(string[] soldierArgs)
        {
            var id = int.Parse(soldierArgs[1]);
            var firstName = soldierArgs[2];
            var lastName = soldierArgs[3];
            var codeNumber = int.Parse(soldierArgs[4]);
            var spy = new Spy(id, firstName, lastName, codeNumber);

            Console.WriteLine(spy.ToString());
        }

        private static void CretaeCommando(string[] soldierArgs)
        {
            var id = int.Parse(soldierArgs[1]);
            var firstName = soldierArgs[2];
            var lastName = soldierArgs[3];
            var salary = double.Parse(soldierArgs[4]);
            var corp = soldierArgs[5];
            var commando = new Commando(id, firstName, lastName, salary, corp);

            var missionCount = (soldierArgs.Length - 6) / 2;
            var indexer = 6;
            for (int i = missionCount; i > 0; i--)
            {
                var missionCodeName = soldierArgs[indexer];
                var missionState = soldierArgs[indexer + 1];
                commando.Missions.Add(new Mission(missionCodeName, missionState));
                indexer += 2;
            }

            Console.WriteLine(commando.ToString());
        }

        private static void CreateEngineer(string[] soldierArgs)
        {
            var id = int.Parse(soldierArgs[1]);
            var firstName = soldierArgs[2];
            var lastName = soldierArgs[3];
            var salary = double.Parse(soldierArgs[4]);
            var corp = soldierArgs[5];
            var engineer = new Engineer(id, firstName, lastName, salary, corp);

            var repairCount = (soldierArgs.Length - 6) / 2;
            var indexer = 6;
            for (int i = repairCount; i > 0; i--)
            {
                var repairPart = soldierArgs[indexer];
                var repairHours = int.Parse(soldierArgs[indexer + 1]);
                engineer.Repairs.Add(new Repair(repairPart, repairHours));
                indexer += 2;
            }

            Console.WriteLine(engineer.ToString());
        }

        private static void CreateLeutenantGeneral(string[] soldierArgs, List<Private> privateSoldiers)
        {
            var id = int.Parse(soldierArgs[1]);
            var firstName = soldierArgs[2];
            var lastName = soldierArgs[3];
            var salary = double.Parse(soldierArgs[4]);
            var leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary);
            var privateNumber = soldierArgs.Length - 5;
            for (int i = 5; i < 5 + privateNumber; i += 1)
            {
                var privateSoldier = privateSoldiers.Where(s => s.Id == int.Parse(soldierArgs[i])).FirstOrDefault();
                leutenantGeneral.AddPrivate(privateSoldier);
            }
            Console.WriteLine(leutenantGeneral.ToString());
        }

        private static void CreatePrivate(string[] soldierArgs, List<Private> privateSoldiers)
        {
            var id = int.Parse(soldierArgs[1]);
            var firstName = soldierArgs[2];
            var lastName = soldierArgs[3];
            var salary = double.Parse(soldierArgs[4]);
            var privateSoldier = new Private(id, firstName, lastName, salary);
            privateSoldiers.Add(privateSoldier);

            Console.WriteLine(privateSoldier.ToString());
        }
    }
}