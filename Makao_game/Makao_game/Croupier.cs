using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makao_game
{
    public class Croupier
    { //he is here to initialize game and deal with deck and stack
        private Deck deck;
        private List<Player> listOfPleyersReference;
        internal Stack<Card> stackReference;

        public Croupier(ref List<Player> listArg, ref Stack<Card> stackArg)
        {
            deck = new Deck(1);
            listOfPleyersReference = listArg;
            stackReference = stackArg;
        }

        public void ShuffleDeck()
        {
            deck.ShuffleDeck();
        }

        internal void startStack()
        {
            stackReference = new Stack<Card>();
            stackReference.Push(TakeCardFromTop());
        }

        public void DealCards(int amount, Player player)
        {
            for (int i = 0; i < amount; i++)
            {
                player.AddCard(TakeCardFromTop());
            }
        }

        public void DealBegginingHand()
        {
            for (int i=0; i<5; i++)
            {
                foreach (var player in listOfPleyersReference)
                {
                    DealCards(1, player);
                }
            }
            
        }

        public int PlaceOnStack(List<Card> cardsToPlaceOnStack)
        {
            if ((cardsToPlaceOnStack.Count == 2) || (cardsToPlaceOnStack.Count == 0) || (cardsToPlaceOnStack.Count > 4))
            {
                MessageBox.Show("Incorrect amount of cards!");
                return -1;
            }

            foreach (var card in cardsToPlaceOnStack)
            {
                if (card.eValue != cardsToPlaceOnStack[0].eValue)
                {
                    MessageBox.Show("Cards doesn't have same value!");
                    return -1;
                }
            }

            foreach (var card in cardsToPlaceOnStack)
            {
                if ((card.eSuit == stackReference.Peek().eSuit) || (card.eValue == stackReference.Peek().eValue))
                {
                    stackReference.Push(card);
                }
                else if (card.eValue == Card.Value.Queen)
                {
                    stackReference.Push(card);
                }
                else
                {
                    MessageBox.Show("Wrong card!");
                    return -1;
                }
            }
            return 1;
        }

        public Card TakeCardFromTop()
        {
            if (deck.queueOfCards.Count == 0)
            {
                Card placeholderForTopOne = stackReference.Pop();
                deck.shufflingList.Clear();
                for(int i=0; i<stackReference.Count; i++)
                {
                    deck.shufflingList.Add(stackReference.Pop());
                }
                deck.ShuffleDeck();
                deck.MoveCardsToQueue();
                stackReference.Push(placeholderForTopOne);
            }

            return deck.queueOfCards.Dequeue();
        }
    }
}
