namespace E08_CardGame
{
    using System;

    public class Card : IComparable<Card>
    {
        public Card(string rank, string suit)
        {
            this.CardRank = (CardRank)Enum.Parse(typeof(CardRank), rank);
            this.CardSuit = (CardSuit)Enum.Parse(typeof(CardSuit), suit);
        }

        public string Name => this.CardRank.ToString() + " of " + this.CardSuit.ToString();

        private CardRank CardRank { get; set; }

        private CardSuit CardSuit { get; set; }

        public int CalculatedPower => (int)this.CardSuit + (int)this.CardRank;

        //not in use ofter creating property with the same name
        //public int CalculatePower() => (int)this.CardSuit + (int)this.CardRank;

        public int CompareTo(Card other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            //var compareRank = this.CalculatedPower.CompareTo(other.CalculatedPower);
            //if (compareRank != 0)
            //{
            //    return compareRank;
            //}
            //return this.CardSuit.CompareTo(other.CardSuit);

            return this.CalculatedPower.CompareTo(other.CalculatedPower);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Card card = obj as Card;

            return this.Name.Equals(card.Name);
        }

        public override int GetHashCode()
        {
            return $"{this.Name} {this.CalculatedPower}".GetHashCode();
        }

        public override string ToString() => $"Card name: {this.CardRank} of {this.CardSuit}; Card power: {this.CalculatedPower}";
    }
}