using System;

namespace interface_prectice {
    interface IA {

        void show();
    }
    interface IB {
        void print();
    }
    public class C : IA, IB {
        public void show() {
            Console.WriteLine("this is a show method of the interface IA");

        }

        public void print() {
            Console.WriteLine("This is a print method from interface IB");
        }
    }
    internal class Program {
        static void Main(string[] args) {
            C obj = new C();

            obj.show();
            obj.print();
            Console.Read();
        }
    }
}
