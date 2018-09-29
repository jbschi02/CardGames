using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;

namespace CardGames
{
    public class PileOfCards
    {
        private List<Card> pile;
        private static Random rng = new Random();
        public PileOfCards()
        {
            pile = new List<Card>();
        }

        public String toString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Card card in this.pile)
            {
                sb.Append(card.toString() + "\n");
            }
            return sb.ToString();
        }

        public void addCard(Card card)
        {
            this.pile.Add(card);
        }

        public void shuffle()
        {
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            int n = this.pile.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do provider.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                Card card = this.pile[k];
                this.pile[k] = this.pile[n];
                this.pile[n] = card;
            }
        }
    }
}
