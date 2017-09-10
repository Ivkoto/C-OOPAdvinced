using System;
using System.Linq;
using System.Text;

namespace E04_Froggy
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            var lake = new Lake(numbers);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}