using System;
namespace CardGames
{
    public class WarGame : Game
    {
        private Player human;
        private Player computer;
        private PileOfCards cardsBeingBattled;

        public WarGame()
        {
            human = new Player();
            computer = new Player();
            cardsBeingBattled = new PileOfCards();
        }

        public override void playGame()
        {
            setup();
        }

        public override void setup()
        {
            makeDeck();

            Console.Out.WriteLine(deck.toString());
        }
    }
}
