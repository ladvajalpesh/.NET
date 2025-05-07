using System;
using ConsoleApp1;
namespace ConsoleApp5 {
    internal class Program  {
        public class A  {
            public void print() {
                Console.WriteLine("this is class A method");
            }
        }
        static void Main(string[] args) {
            A a = new A();
            D1 d1 = new D1();
            d1.mymethod();
            a.print();

            Console.Read();
        }

    }
}

