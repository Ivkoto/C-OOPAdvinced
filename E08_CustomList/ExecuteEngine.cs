using System;

namespace CustomList
{
    public class ExecuteEngine
    {
        public ExecuteEngine()
        {
            this.CommandInterpreter = new CommandInterpreter();
        }

        public CommandInterpreter CommandInterpreter { get; set; }

        public void Run()
        {
            var cmdArgs = Console.ReadLine().Split(' ');
            while (cmdArgs[0] != "END")
            {
                this.CommandInterpreter.ExecuteCmd(cmdArgs);
                cmdArgs = Console.ReadLine().Split(' ');
            }
        }
    }
}