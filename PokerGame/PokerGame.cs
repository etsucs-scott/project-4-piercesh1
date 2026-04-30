using System.Xml.Serialization;

namespace PokerGame
{
    public class PokerGame
    {
        public List<Player> Players { get; set; } = new();
        public Deck Deck { get; set; } = new();

        public int CurrentPlayerIndex { get; set; } = new();

        public Player CurrentPlayer => Players[CurrentPlayerIndex];

        public void StartGame(int playercount)
        {
            Players.Clear();
            Deck = new Deck();
            Deck.Shuffle();

            for (int i = 1; i <= playercount; i++)
            {
                Players.Add(new Player
                {
                    Name = $"Player {i}"
                });
            }
            DealInitialCards();
        }

        private void DealInitialCards()
        {
            foreach (var player in Players) 
            { 
                player.ClearHand();
            }

            for (int i = 0; i < 2; i++)
            {
                foreach (var player in Players)
                {
                    player.Hand.Add(Deck.Draw());
                }
            }
        }

        public void NextTurn()
        {
            do
            {
                CurrentPlayerIndex = (CurrentPlayerIndex + 1) % Players.Count;
            }
            while (Players[CurrentPlayerIndex].Folded);
        }

        public void Fold()
        {
            CurrentPlayer.Folded = true;
            NextTurn();
        }
    }
}
