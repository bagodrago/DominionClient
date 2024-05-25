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
        public List<Card> contents { get; }

        public virtual void AddToTopOfPile(Card recruit) 
        {
            contents.Insert(0, recruit);
        }
        public virtual void AddToTopOfPile(List<Card> recruits) 
        { 
            
        }

        public virtual Card RemoveFromTopOfPile() 
        {
            Card temp = contents.First();
            contents.Remove(temp);
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
            contents.CopyTo(temp);
            contents.Clear();
            return temp;
        }

        public virtual void SelectFromPile(int howMany, Card cardType) { } // Show contents to player and select a number
    }
}
