namespace E02_Collection
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var createArgs = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var myList = new ListyIterator<string>(createArgs.Skip(1).ToArray());

            CommandsExecution(myList);
        }

        private static void CommandsExecution(ListyIterator<string> myList)
        {
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                try
                {
                    switch (command)
                    {
                        case "Move":
                            Console.WriteLine(myList.Move());
                            break;

                        case "HasNext":
                            Console.WriteLine(myList.HasNext());
                            break;

                        case "Print":
                            myList.Print();
                            break;

                        case "PrintAll":
                            myList.PrintAll();
                            break;
                    }
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }
        }
    }
}