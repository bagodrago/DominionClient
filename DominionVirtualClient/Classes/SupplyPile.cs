using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient.Classes
{
    internal struct SupplyPile
    {
        public Card Goods { get; private set; }
        public int Stock { get; private set; }
        public SupplyPile(Card goods, int stock) 
        {
            Goods = goods;
            Stock = stock;
        }

        public int Buy(int howMany, Player buyer)
        {
            if (Stock < howMany) return -1;

            buyer.Treasure -= Goods.Cost;
            Stock -= howMany;

            return 0;
        }

        public bool isEmpty() { return Stock < 1; }
    }
}
