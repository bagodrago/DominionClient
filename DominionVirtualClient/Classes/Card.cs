using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient.Classes
{
    internal abstract class Card
    {
        public string Name { get; }
        public int Cost { get; }
        public int Player { get; set; }

        public virtual void AddedToHand() { }
        public virtual void Cleanup() { Discard(); }

        // Action methods
        public virtual void GainTreasure(int gained) { }
        public virtual void LoseTreasure(int lost) { }
        public virtual void GainAction(int gained) { }
        public virtual void GainBuy(int gained) { }

        // Cleanup methods
        public virtual void Discard() { }
        public virtual void Trash() { }
        public virtual void Gain() { }

        // Player choice
        public virtual List<Card> SelectFromHand() { return new List<Card>(); }
    }
}
