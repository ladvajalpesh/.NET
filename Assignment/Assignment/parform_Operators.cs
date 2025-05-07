using System;
using System.Timers;

namespace Assignment
{
    internal class perform_Operators
    {
        static void Main(string[] arg)
        {

            int a = 50;
            int b = 25;
            //Console.WriteLine("enter the value of a:");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter the value of b:");
            //b = Convert.ToInt32(Console.ReadLine());

            // Arithmetic operators(+,-,*,/,%,++,--,)
            Console.WriteLine("addition:" + (a + b));
            Console.WriteLine("subtraction:" + (a - b));
            Console.WriteLine("multiplication:" + (a * b));
            Console.WriteLine("division:" + (a / b));
            Console.WriteLine("modual:" + (a % b));
            a++;
            Console.WriteLine("increament: " + a);
            b--;
            Console.WriteLine("dicreament: " + b);



            // Assignment operators(= ,+=,-=,)
            a = b;
            Console.WriteLine("b value assign a : " + a);
            a += b;
            Console.WriteLine(a);
            a -= b;
            Console.WriteLine(a);

            //Comparison operators

            Console.WriteLine("a is less then or equal to b: " + (a <= b));
            Console.WriteLine("a is greater then or equal b: " + (a >= b));
            Console.WriteLine("a is less then b: " + (a < b));
            Console.WriteLine("a is greater then b: " + (a > b));

            // Equality operators
            Console.WriteLine("compar the two value: " + (a == b));
            Console.WriteLine("a is not equal to b: " + (a != b));

            // Boolean logical operators(&& ,||,!)
            int i = 20;
            int j = 12;
            int k = 13;
            if (i > j && k < i)
            {
                Console.WriteLine("And operators");
            }

            if (i == j || j < k) {
                Console.WriteLine("or operators");
            }

            if (i != j)
            {
                Console.WriteLine("not operator i in not equal to j");
            }


            //Betwise and shift operators(<<,>>,)
           
           
                Console.WriteLine("shift left" , a<<b);
         


            Console.Read();
        }
    }
}
