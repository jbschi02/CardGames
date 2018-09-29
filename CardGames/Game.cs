using System;
using System.Collections.Generic;
namespace CardGames
{
    public abstract class Game
    {
        protected PileOfCards deck;
        public Game()
        {
            deck = new PileOfCards();
        }

        public virtual void makeDeck()
        {
            deck = new PileOfCards();
            for (int i = 0; i < 13; i++)
            {
                deck.addCard(new Card(i, 0));
                deck.addCard(new Card(i, 1));
                deck.addCard(new Card(i, 2));
                deck.addCard(new Card(i, 3));
            }
            Console.Out.WriteLine(deck.toString());

            deck.shuffle();
        }

        public abstract void playGame();
        public abstract void setup();
    }
}
