using mylib;

namespace ConsoleApp6 {
    internal class Program : Class1 {
        static class Animal {
            public static void print() {
                Console.WriteLine(" mymethod ");
            }
        }

        public class A {
            public void mymethod() {
                Console.WriteLine("this is project 1 class ");
            }
        }
        static void Main(string[] args) {
            Class1 c = new Class1();
            c.show();
            Animal.print();
            A a = new A();
            a.mymethod();

            Console.Read();
        }
    }
}
