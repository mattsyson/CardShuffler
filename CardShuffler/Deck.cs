using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardShuffler
{
    public class Deck
    {
        string[] cardValues = new string[] { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        static Random r = new Random();

        internal List<Card> GetDeck()
        {
            List<Card> deck = new List<Card>();

            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach(var cardValue in cardValues)
                {
                    Card card = new Card
                    {
                        Value = cardValue,
                        Suit = suit.ToString()
                    };

                    deck.Add(card);
                }
            }

            return deck;
        }

        internal static List<Card> Shuffle(List<Card> deck)
        {
            List<Card> shuffledDeck = new List<Card>();

            for(int i = deck.Count - 1; i >= 0; i--)
            {
                int k = r.Next(i + 1);
                shuffledDeck.Add(deck[k]);
                deck.RemoveAt(k);
            }

            return shuffledDeck;
        }
    }
}
