using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_prectice
{
    internal class Butterfly_Pattern
    {
        static void Main(string[] agrs) {
            int num = 5;
            for (int i = 1; i <= num; i++)
            {
                for (int j = 1; j <= i; j++) {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i= num; i >=1 ; i--)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            for (int i=1;i<=num;i++) {
                for (int j = i; j >=1; j--) {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }

        }

    }
}
