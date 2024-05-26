using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient.Classes
{
    internal class PlayField : Pile
    {
        public PlayField(Player owner) { Owner = owner; }

        public void Cleanup() { } // move to discard
    }
}
