namespace PokerGame
{
    public class Deck
    {
        private List<Card> cards;
        private Random rng = new();
        /// <summary>
        /// This will help show which players has the better cards.
        /// </summary>
        public Deck()
        {
            cards = Enum.GetValues<Suit>()
                .SelectMany(s => Enum.GetValues<Rank>()
                .Select(r => new Card { Suit = s, Rank = r }))
                .ToList();
        }
        /// <summary>
        /// This will change the cards of the players when you start a game
        /// </summary>
        public void Shuffle()
        {
            cards = cards.OrderBy(_ => rng.Next()).ToList();
        }

        public Card Draw()
        {
            var card = cards.First();
            cards.RemoveAt(0);
            return card;
        }
    }
}
