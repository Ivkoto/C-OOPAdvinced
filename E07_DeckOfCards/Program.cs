namespace E07_DeckOfCards
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            foreach (var suit in Enum.GetNames(typeof(CardSuit)))
            {
                foreach (var rank in Enum.GetNames(typeof(CardRank)))
                {
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }


    }
}