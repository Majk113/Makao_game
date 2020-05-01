using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makao_game
{
    public class Card
    {
        public enum eValue {Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace};
        public enum eSuit { Spades, Hearts, Clubs, Diamonds };


        public eSuit Suit { get; private set; }
        public eValue Value { get; private set; }
        public bool IsFunctional { get; private set; }



        public Card(eSuit suit, eValue value)
        {
            Suit = suit;
            Value = value;

            if ((value == eValue.Two) || (value == eValue.Three) || (value == eValue.Four) || (value == eValue.Jack) || (value == eValue.Ace))
            {
                IsFunctional = true;
            }
            else if (((value == eValue.Queen) || (value == eValue.King)) && ((suit == eSuit.Hearts) || (suit == eSuit.Spades)))
            {
                IsFunctional = true;
            }
            else
            {
                IsFunctional = false;
            }
        }
    }
}
