using System;

namespace E02_CardRank
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Console.WriteLine(input + ":");

            var enumvalues = Enum.GetValues(typeof(CardSteck));

            foreach (var card in enumvalues)
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
    }
}