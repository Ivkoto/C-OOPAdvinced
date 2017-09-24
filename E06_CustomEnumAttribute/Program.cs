namespace E06_CustomEnumAttribute
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var category = Console.ReadLine();
            Type type;
            if (category == "Rank")
            {
                PrintAttributes(typeof(CardRank));                
            }
            else
            {
                PrintAttributes(typeof(CardSuit));
            }
        }

        public static void PrintAttributes(Type type)
        {
            var attributes = type.GetCustomAttributes(false);
            Console.WriteLine(attributes[0]);
        }
    }
}