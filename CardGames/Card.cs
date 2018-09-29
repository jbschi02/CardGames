using System;
namespace CardGames
{
    public class Card
    {
        //
        private int rank;
        private int suit;
        private String[] suitNames = { "Hearts", "Diamonds", "Spades", "Clubs" };
        private String[] cardNumbers = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        public Card(int rank, int suit)
        {
            this.rank = rank;
            this.suit = suit;
        }

        public String toString()
        {
            return cardNumbers[this.rank] + " of " + suitNames[this.suit];
        }
    }
}
