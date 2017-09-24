using System;
using System.Collections.Generic;

namespace E03_CardPower
{
    public class Program
    {
        public static void Main()
        {
            try
            {
                var rank = Console.ReadLine();
                var suit = Console.ReadLine();

                var card = new Card(rank, suit);

                Console.WriteLine(card);
            }
            catch (Exception e )
            {
                Console.WriteLine(e.Message);
            }
            
        }
    }
}