using System;

namespace prectice_setion {
    public class A {

        public int x { get; set; }
        public int y { get; set; }


        public void print() {
            Console.WriteLine("this is defualt method");
        }
        public virtual void show() {
            Console.WriteLine("this is base class");
        }
    }
    public class B : A {
        //method overloading
        public void print(int x, int y) {
            Console.WriteLine(" X " + x + " y " + y);

        }

        // method overriding

        public override void show() {
            Console.WriteLine("this is derived class");
        }
    }

    internal class inheritance {
        static void Main() {
            B b = new B();
            b.show();
            b.print(10, 20);
        }
    }
}
