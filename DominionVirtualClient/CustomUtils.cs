using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DominionVirtualClient
{
    internal static class CustomUtils
    {
        public static Random rng;

        public static void Shuffle<T>(IList<T> container)
        {
            int n = container.Count();
            while (n > 1)
            {
                int k = rng.Next(n--);
                T temp = container[n];
                container[n] = container[k];
                container[k] = temp;
            }
        }
    }
}
