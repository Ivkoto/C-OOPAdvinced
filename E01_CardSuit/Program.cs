using System;

namespace E01_CardSuit
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Console.WriteLine(input + ":");

            var enumInfo = Enum.GetValues(typeof(CardSuit));
            foreach (var item in enumInfo)
            {
                Console.WriteLine($"Ordinal value: {(int)item}; Name value: {item}");          
            }
            
        }
    }
}