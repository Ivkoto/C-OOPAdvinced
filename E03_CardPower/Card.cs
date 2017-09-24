using System;

namespace E03_CardPower
{
    public class Card
    {
        public Card(string rank, string suit)
        {
            this.CardRank = (CardRank)Enum.Parse(typeof(CardRank), rank);
            this.CardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), suit);
        }

        private CardRank CardRank { get;  set; }

        private CardSuit CardSuit { get;  set; }

        public int CalculatePower() => (int)this.CardSuit + (int)this.CardRank;

        public override string ToString() => $"Card name: {this.CardRank} of {this.CardSuit}; Card power: {CalculatePower()}";
    }
}