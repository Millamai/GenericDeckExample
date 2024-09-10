using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDeckExample
{
    internal class Card
    {

        public enum Suits
        {
            Hearts,    // Hjerter
            Diamonds,  // Ruder
            Clubs,     // Kløver
            Spades     // Spar
        }

        public int Value { get; set; }
        public Suits Suit { get; set; }
        public Card(int val, Suits s)
        {
            Value = val;
            Suit = s; 
        }


        public override string ToString()
        {
            return "Kort: "+Suit +":"+Value;
        }
    }
}
