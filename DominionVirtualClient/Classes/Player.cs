using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient.Classes
{
    internal class Player
    {
        public Player() 
        {
            Deck = new Deck(this);
            Hand = new Hand(this);
            DiscardPile = new DiscardPile(this);
        }

        public Deck Deck { get; }
        public Hand Hand { get; }
        public DiscardPile DiscardPile { get; }

        public int Treasure { get; set; }
        public int Actions { get; }
        public int Buys { get; }

    }
}
