using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Makao_game
{
    public class Card
    {
        public enum Value {Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace};
        public enum Suit {Spades, Hearts, Clubs, Diamonds};

        public readonly Suit eSuit;
        public readonly Value eValue;
        public readonly bool isFunctional;

        public Card(Suit sui, Value val)
        {
            eSuit = sui;
            eValue = val;

            if ((val == Value.Two) || (val == Value.Three) || (val == Value.Four) || (val == Value.Jack) || (val == Value.Ace))
            { 
                isFunctional = true;
            }
            else if (((val == Value.Queen) || (val == Value.King)) && ((sui == Suit.Hearts) || (sui == Suit.Spades)))
            {
                isFunctional = true;
            }
            else
            {
                isFunctional = false;
            }
        }
    }
}
