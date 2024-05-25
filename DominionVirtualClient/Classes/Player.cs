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
            Deck = new Deck();
            Hand = new Hand();
            DiscardPile = new DiscardPile();
        }

        public Deck Deck { get; }
        public Hand Hand { get; }

        public DiscardPile DiscardPile { get; }

    }
}
