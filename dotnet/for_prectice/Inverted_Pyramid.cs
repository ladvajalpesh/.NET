using System;

namespace for_prectice
{
    internal class Inverted_Pyramid
    {
        public static void Main(string[] arg)
        {
            int i;
            int j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 5; j >= i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
