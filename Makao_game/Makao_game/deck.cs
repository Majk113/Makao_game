using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makao_game
{
    public class Deck
    {
        public List<Card> shufflingList = new List<Card>();
        public Queue<Card> queueOfCards = new Queue<Card>();
        private Random rnd = new Random();

        public Deck(int howManyDecks)
        {
            for (int i = 0; i < howManyDecks; i++)
            {
                foreach (var suit in (Card.Suit[])Enum.GetValues(typeof(Card.Suit)))
                {
                    foreach (var value in (Card.Value[])Enum.GetValues(typeof(Card.Value)))
                    {

                        shufflingList.Add(new Card(suit, value));
                        i++;
                    }
                }
            }
            ShuffleDeck();
            MoveCardsToQueue();
        }

        public void MoveCardsToQueue()
        {
            foreach (var card in shufflingList)
            {
                queueOfCards.Enqueue(card);
            }
        }     

        public void ShuffleDeck()
        {
            double trials = 100;
            for (int t = 0; t < trials; ++t)
            {
                Shuffler.Shuffle(shufflingList, rnd);
            }
        }
    }
}
    


