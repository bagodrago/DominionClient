using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient.Classes
{
    internal class Hand : Pile
    {
        public Hand(Player owner) { Owner = owner; }

        public void Play(int index)
        {
            var temp = Contents[index];

            Contents.RemoveAt(index);
            Owner.PlayField.AddToTopOfPile(temp);

            if (temp is PlayableCard pc)
            {
                pc.Effect();
            }

            // Check for effects like Merchant

        }

        public void Discard(int index)
        {
            Card temp = Contents[index];
            Contents.RemoveAt(index);
            Owner.DiscardPile.AddToTopOfPile(temp);
        }
    }
}
