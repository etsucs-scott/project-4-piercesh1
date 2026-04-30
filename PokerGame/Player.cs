namespace PokerGame
{
    public class Player
    {
        /// <summary>
        /// This will show the name of the players and the cards they have.
        /// it will also show the chips and if they folded
        /// </summary>
        public string Name { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();
        public int Chips { get; set; } = 1000;

        public bool Folded { get; set; } = false;

        public void ClearHand()
        {
            Hand.Clear();
            Folded = false;
        }
    }
}
