//Demonstrate how to use a constructor of the base class from a derived class using base() keyword in inheritance.
//Use any example of your choice.

using System;

namespace inheritance_prectice {
    public class baseclass {
        public baseclass() {
            Console.WriteLine("constructor of baseclass");
        }

    }
    public class derivedclass : baseclass {
        public derivedclass() : base() {
            Console.WriteLine("constructor of derivedclass");
        }
    }

    internal class Class3 {
        static void Main(String[] args) {
            derivedclass d = new derivedclass();


        }

    }
}
