using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient.Classes
{
    internal abstract class Pile
    {
        public List<Card> Contents { get; }
        internal Player Owner { get; set; }

        public virtual void AddToTopOfPile(Card recruit) 
        {
            Contents.Insert(0, recruit);
        }
        public virtual void AddToTopOfPile(Card[] recruits) 
        { 
            foreach (Card recruit in recruits) 
            { 
                AddToTopOfPile((Card) recruit);
            }
        }

        public virtual Card RemoveFromTopOfPile() 
        {
            Card temp = Contents.First();
            Contents.Remove(temp);
            return temp; 
        }
        public virtual Card[] RemoveFromTopOfPile(int howMany)
        {
            List<Card> temp = new List<Card>();
            for (int i = 0; i < howMany; i++)
            {
                temp.Add(RemoveFromTopOfPile());
            }
            return temp.ToArray();
        }

        public virtual Card[] EmptyPileContents() 
        { 
            // Will likely not be necessary if using an animation or will be shorthand
            Card[] temp = {};
            Contents.CopyTo(temp);
            Contents.Clear();
            return temp;
        }

        
        public virtual Card[] SelectFromPile(int howMany, Card cardType) // (!) Not implemented
        {
            throw new NotImplementedException();
            /*
            Card[] selected = new Card[howMany];

            // Show pop-up for player here

            return selected;
            */
        }
    }
}
