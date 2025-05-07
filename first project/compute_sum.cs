using System;

namespace first_project
{
    internal class compute_sum
    {
        public static void Main(string[] args)
        { 
            Console.WriteLine(test(1, 2));
            Console.WriteLine(test(2, 3));
            Console.WriteLine(test(2, 2));
            Console.ReadLine();
            // Console.WriteLine("Enter the second number: ");
        }
        public static int test(int x, int y)
        {
            return x == y ? (x + y) * 3 : x = y;
        }
    }
}
