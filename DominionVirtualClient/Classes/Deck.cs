using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient.Classes
{
    internal class Deck : Pile
    {
        public Deck(Player owner) { Owner = owner; }

        public void Draw()
        {
            Card temp = RemoveFromTopOfPile();
            Owner.Hand.AddToTopOfPile(temp);
            temp.AddedToHand();
        }
        public void Draw(int howMany)
        {
            for (int i = 0; i < howMany; i++) 
            { 
                Draw(); 
            }
        }

        public void Shuffle() 
        { 
            
        }
    }
}
