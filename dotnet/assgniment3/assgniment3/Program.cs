using System;

namespace assgniment3 {

    public class A {
        //constrocter overloading
        public A() {
            Console.WriteLine("Default constructor of class A");
        }

        public A(int a) {
            Console.WriteLine("Parameterized constructor of class A with value: " + a);
        }
    }

    internal class Program {
        public static void Main(string[] args) {
            A a = new A(10);

            Console.Read();


        }
    }
}
