using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient.Classes
{
    internal abstract class ActionCard : Card
    {
        public void Play() 
        {
            // Place into play field

            Effect();
        }
        public abstract void Effect();

        
    }
}
