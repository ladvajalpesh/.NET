using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_prectice
{
    internal class square_pattern
    {
        /// squere pattern printing
        public static void Main(string[] args) {
            int i;
            int j;
            for (i = 1; i <=5; i++) {
                for (j = 5; j >= 1; j--)
                {
                    Console.Write(" * ");
                }
                Console.WriteLine();
            }
        }
    }
}
