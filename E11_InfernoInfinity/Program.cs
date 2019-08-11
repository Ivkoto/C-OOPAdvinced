using E11_InfernoInfinity.Abstracts;
using E11_InfernoInfinity.Enums;
using E11_InfernoInfinity.Interfaces;
using E11_InfernoInfinity.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace E11_InfernoInfinity
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StartGame();
        }

        private static void StartGame()
        {
            var weapons = new List<Weapon>();

            string input;
            try
            {
                while ((input = Console.ReadLine()) != "END")
                {
                    var tokens = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    var command = tokens[0];
                    var commandArgs = tokens.Skip(1).ToArray();

                    var commandExecutor = new CommandExecutor(command, commandArgs, weapons);
                    commandExecutor.ExecuteCommand();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Unknown command!");
                StartGame();
            }
        }
    }
}