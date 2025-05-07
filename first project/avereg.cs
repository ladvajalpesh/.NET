using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class avereg
    {
        public static void Main()
        {
            int num;
            int sum = 0;
            double avg;

            Console.WriteLine("Enter the number of elements:");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Enter number {i}:");
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;
            }

            avg = (double)sum / num;
            Console.WriteLine($"The average is: {avg}");
        }
    }
}
