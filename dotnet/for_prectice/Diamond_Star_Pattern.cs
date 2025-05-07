using System;

using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace for_prectice
{
    internal class Diamond_Star_Pattern
    {
        public Diamond_Star_Pattern()
        {
            int i;
            int j;
            for (i = 1; i <= 5; i++)
            {
                for (j = i; j <= 5; j++)
                {
                    Console.Write("");
                }
                for (j = 1; j <= (2 * i - 1); j++)
                {

                    Console.Write("*");
                }

                Console.WriteLine();
            }
            for (j = i; j <= 5; j++)
            {
                Console.Write("");
            }
            for (j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
