using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class specified_formula
    {
        public static void Main() {
            int x, y, z;
            Console.WriteLine("enter the value of x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of y");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the value of z");
            z = int.Parse(Console.ReadLine());

            double Result1 = (x + y) * z;
               double result2 = (x+y)*(y*z);

            Console.WriteLine($"Result1: {Result1}");
            Console.WriteLine($"Result2: {result2}");
        }
    }
}
