namespace E07_DeckOfCards
{
    using System;

    public class Card : IComparable<Card>
    {
        public Card(string rank, string suit)
        {
            this.CardRank = (CardRank)Enum.Parse(typeof(CardRank), rank);
            this.CardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), suit);
        }

        private CardRank CardRank { get; set; }

        private CardSuit CardSuit { get; set; }

        public int CalculatePower() => (int)this.CardSuit + (int)this.CardRank;

        public int CompareTo(Card other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var compareRank = this.CardRank.CompareTo(other.CardRank);
            if (compareRank != 0)
            {
                return compareRank;
            }
            return this.CardSuit.CompareTo(other.CardSuit);
        }

        public override string ToString() => $"Card name: {this.CardRank} of {this.CardSuit}; Card power: {CalculatePower()}";
    }
}