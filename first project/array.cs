using System;
using System.Linq;

namespace first_project
{
    internal class array
    {
        public static void Main(string[] args)
        {
            int[] arr = { 14, 25, 51, 25, 62 };
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);

            }
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            Console.WriteLine("sum of the number is " + sum);
            Console.WriteLine("max number is " + arr.Max());
            Console.WriteLine("average of the number is " + arr.Average());
            Console.WriteLine("min number is " + arr.Min());
            //  Console.WriteLine("middial number is " + arr[] / 2);
            int middleIndex = arr.Length / 2;

            if (arr.Length % 2 == 0)
            {
                // If even, display the average of the two middle elements
                double middleElement = (arr[middleIndex - 1] + arr[middleIndex]) / 2.0;
                Console.WriteLine("Middle element is " + middleElement);
            }
            else
            {
                // If odd, display the middle element
                Console.WriteLine("Middle element is " + arr[middleIndex]);
            }
        }
    }
}

