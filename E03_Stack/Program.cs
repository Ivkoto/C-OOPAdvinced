using System;

namespace E03_Stack
{
    public class Program
    {
        public static void Main()
        {
            var myStack = new Stack<int>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                var tokens = input.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    switch (tokens[0])
                    {
                        case "Push":
                            for (int i = 1; i < tokens.Length; i++)
                            {
                                myStack.Push(int.Parse(tokens[i]));
                            }
                            break;

                        case "Pop":
                            myStack.Pop();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (var elem in myStack)
                {
                    Console.WriteLine(elem);
                }
            }            
        }
    }
}