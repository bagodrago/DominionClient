using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient.Classes
{
    internal class Player
    {
        public Player() { }

        private Deck myDeck { get; set; }
        private Hand myHand { get; }

        private DiscardPile myDiscardPile { get; }

    }
}
