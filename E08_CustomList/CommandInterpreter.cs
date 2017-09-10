using System;

namespace CustomList
{
    public class CommandInterpreter
    {
        public CommandInterpreter()
        {
            this.CustomList = new CustomList<string>();
        }

        private ICustomList<string> CustomList { get; set; }

        public void ExecuteCmd(string[] cmdArgs)
        {
            var command = cmdArgs[0];
            string element;
            int index1;
            int index2;
            switch (command)
            {
                case "Add":
                    element = cmdArgs[1];
                    this.CustomList.Add(element);
                    break;

                case "Remove":
                    index1 = int.Parse(cmdArgs[1]);
                    this.CustomList.Remove(index1);
                    break;

                case "Contains":
                    element = cmdArgs[1];
                    Console.WriteLine(this.CustomList.Contains(element));
                    break;

                case "Swap":
                    index1 = int.Parse(cmdArgs[1]);
                    index2 = int.Parse(cmdArgs[2]);
                    this.CustomList.Swap(index1, index2);
                    break;

                case "Greater":
                    element = cmdArgs[1];
                    Console.WriteLine(this.CustomList.CountGreaterThan(element));
                    break;

                case "Max":
                    Console.WriteLine(this.CustomList.Max());
                    break;

                case "Min":
                    Console.WriteLine(this.CustomList.Min());
                    break;

                case "Sort":
                    this.CustomList = Sorter.Sort(this.CustomList);
                    break;

                case "Print":
                    foreach (var item in this.CustomList)
                    {
                        Console.WriteLine(item);
                    }
                    break;
            }
        }
    }
}