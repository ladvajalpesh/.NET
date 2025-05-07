using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class revers_array
    {
        public static void Main(string[] args)
        {
            int n;
            int[] arr = new int[100];

            Console.WriteLine("Enter the number of elements:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter number {i}:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The original array is:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{arr[i]}");
            }
            Console.WriteLine("\nrevers array ");
            for (int i = n; i > 0; i--)
            {
                Console.Write($"{arr[i]}");

            }
        }
    }
}
