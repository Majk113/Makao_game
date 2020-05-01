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

        public delegate Card mojDelegatTest(int amount);
        public mojDelegatTest toJestMojDelegat;

        public Player(string name, ref Croupier refArg)
        {
            croupier = refArg;
            sName = name;
            Console.WriteLine("Players name: " + sName);
        }

        internal void AddCard(Card card)
        {
            Hand.Add(card);
        }

        internal void PickACard(int amount)
        {
            toJestMojDelegat(amount);
            //croupier.DealCards(amount, this);
        }

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
