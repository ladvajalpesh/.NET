using System;

namespace inheritance_prectice {

    public class A {
        public virtual void display() {
            Console.WriteLine("Base class method");
        }
    }
    public class B : A {
        public override void display() {
            Console.WriteLine("Derived class method");
        }
    }
    internal class Class5 {
        static void Main(string[] agrs) {

        }

    }
}
