﻿using System;
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
        public Player Owner { get; set; }

        public virtual void AddedToHand() { }
        public virtual void Cleanup() { DiscardSelf(); }


        public void DiscardSelf() { }
        public void TrashSelf() { }
        public void GainSelf() { }
        public void ShuffleSelf() { }
    }
}
