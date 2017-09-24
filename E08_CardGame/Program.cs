using System;
using System.Collections.Generic;

namespace E08_CardGame
{
    public class Program
    {
        private static Card biggestCard;
        private static String winner;

        public static void Main()
        {
            GameStart();
            PrintWinner();
        }

        private static void PrintWinner()
        {
            Console.WriteLine($"{winner} wins with {biggestCard.Name}.");
        }

        private static void GameStart()
        {
            var firstPerson = Console.ReadLine();
            var secondPerson = Console.ReadLine();

            var deck = CreateDeck();
            var firstCardHand = new List<Card>();
            var secondCardHand = new List<Card>();

            while (firstCardHand.Count < 5 || secondCardHand.Count < 5)
            {
                var cardTokens = Console.ReadLine().Split(new string[] { " ", "of" }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    var currentCard = new Card(cardTokens[0], cardTokens[1]);
                    if (deck.Contains(currentCard))
                    {
                        deck.Remove(currentCard);
                        if (firstCardHand.Count < 5)
                        {
                            firstCardHand.Add(currentCard);
                            BiggestCardCheck(currentCard, firstPerson);
                        }
                        else
                        {
                            secondCardHand.Add(currentCard);
                            BiggestCardCheck(currentCard, secondPerson);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("No such card exists.");
                }
            }            
        }

        private static void BiggestCardCheck(Card currentCard, string currentPerson)
        {
            if (biggestCard == null || currentCard.CompareTo(biggestCard) > 0)
            {
                biggestCard = currentCard;
                winner = currentPerson;
            }
        }

        private static List<Card> CreateDeck()
        {
            var deck = new List<Card>();

            foreach (var suit in Enum.GetNames(typeof(CardSuit)))
            {
                foreach (var rank in Enum.GetNames(typeof(CardRank)))
                {
                    deck.Add(new Card(rank, suit));
                }
            }

            return deck;
        }
    }
}