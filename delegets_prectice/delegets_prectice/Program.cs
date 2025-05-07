using System;

namespace delegets_prectice {
    public delegate void myDelegate(int a, int b);

    class calculator {
        public static void add(int a, int b) {
            Console.WriteLine("Addition is : " + (a + b));
        }
        public static void sub(int a, int b) {
            Console.WriteLine("substraction is : " + (a - b));
        }
        public static void mul(int a, int b) {
            Console.WriteLine("multiplication is : " + (a * b));
        }
    }
    internal class Program {
        static void Main(string[] args) {
            myDelegate dl = new myDelegate(calculator.add);

            myDelegate d11 = calculator.add; // referance
                                             
            //// single casting

            dl.Invoke(20, 30);
            dl = calculator.sub;
            dl(20, 30);
            dl = calculator.mul;
            dl(20, 30);

            /// multicasting
            dl += new myDelegate(calculator.sub);
            dl += new myDelegate(calculator.mul);
            dl(10, 20);

            // remove the substration method 
            dl -= new myDelegate(calculator.sub);
            dl(10, 20);
            Console.Read();
        }
    }
}
