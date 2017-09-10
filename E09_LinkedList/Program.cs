using System;
using System.Text;

namespace E09_LinkedList
{
    public class Program
    {
        public static void Main()
        {
            var list = new LinkedList<int>();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var args = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                switch (args[0])
                {
                    case "Add":
                        list.Add(int.Parse(args[1]));
                        break;

                    case "Remove":
                        list.Remove(int.Parse(args[1]));
                        break;
                }
            }

            Console.WriteLine(list.Count);
            Console.WriteLine(string.Join(" ", list));
        }
    }
}