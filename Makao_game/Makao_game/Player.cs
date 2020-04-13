using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makao_game
{
    public class Player
    {
        public string sName;
        public int iID;

        internal List<Card> Hand = new List<Card>();
        internal List<Card> ToPlaceOnStack = new List<Card>();
        private Croupier croupier;
        private bool isPaused;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">Player's name</param>
        /// <param name="refArg">Reference to croupier</param>
        public Player(string name, ref Croupier refArg)
        {
            croupier = refArg;
            sName = name;
            Console.WriteLine("Players name: " + sName);
        }

        /// <summary>
        /// Internal Method to add card to Hand
        /// </summary>
        /// <param name="card"></param>
        internal void AddCard(Card card)
        {
            Hand.Add(card);
        }

        /// <summary>
        /// Request croupier to give a card
        /// </summary>
        /// <param name="amount"></param>
        internal void GiveMeCard(int amount)
        {
            croupier.DealCards(amount, this);
        }

        /// <summary>
        /// Place cards on stack
        /// </summary>
        internal void PlaceOnStack()
        {
            if (croupier.PlaceOnStack(ToPlaceOnStack) == 1)
            {
                ToPlaceOnStack.Clear();
            }
            else
            {
                foreach (var card in ToPlaceOnStack)
                {
                    Hand.Add(card);
                }
                ToPlaceOnStack.Clear();
            }
        }

        /// <summary>
        /// Adding cards to list which is beeing prepared to place on stack
        /// </summary>
        /// <param name="index"></param>
        internal void AddCardToPrepared(int index)
        {
            try
            {
                ToPlaceOnStack.Add(Hand[index]);
                Hand.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Inocorrect index!");
            }
        }

        internal void ReturnCardsToHand()
        {
            foreach (var card in ToPlaceOnStack)
            {
                Hand.Add(card);
            }
            ToPlaceOnStack.Clear();
        }
    }
}
