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
            CustomUtils.Shuffle(Contents);
        }

        public Card[] Reveal(int howMany)
        {
            return new Card[howMany];
        }
    }
}
