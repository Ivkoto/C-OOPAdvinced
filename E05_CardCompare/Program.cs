using System;

namespace E05_CardCompare
{
    public class Program
    {
        public static void Main()
        {
            var cardOne = ReadCard();
            var cardTwo = ReadCard();

            var compareResult = cardOne.CompareTo(cardTwo);
            if (compareResult >= 0)
            {
                Console.WriteLine(cardOne);
            }
            else 
            {
                Console.WriteLine(cardTwo);
            }
        }

        public static Card ReadCard()
        {
            var rank = Console.ReadLine();
            var suit = Console.ReadLine();
            return new Card(rank, suit);
        }
    }
}