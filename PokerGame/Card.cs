namespace PokerGame
{
    /// <summary>
    /// Here is the suit and rank, it will show what cards the players will have
    /// </summary>
    public enum Suit { Hearts, Diamonds, Clubs, Spades}
    public enum Rank { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten}

    public enum HandRank { HighCard, Pair, TwoPair, ThreeOfAKind, Straight, Flush, FullHouse, FourOfAKind, StraightFlush}
    public class Card
    {
        public Suit Suit { get; set; }
        public Rank Rank { get; set; }

        public override string ToString() => $"{Rank} of {Suit}";
    }
}
