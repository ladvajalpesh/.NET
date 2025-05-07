using System;

namespace lecture0804 {
    public class A {
        public string Name { get; set; }
        public int Id { get; set; }
         //default constructor of class A
        public A()
        {

            Console.WriteLine("base class constructer");
        }
      //  perameterized constructor of class A
        public A(string name)
        {
            Name = name;
            Console.WriteLine("Name is " + name);
        }
        public void print() {
            Console.WriteLine("base class method");
        }
    }
    public class B : A
    {
        /// default constructor of class B
        public B()
        {

            Console.WriteLine("derived class Constructor");
        }

       /// perameterized constructor of class B
        public B(string name, int id) : base(name)
        {
            Id = id;
            Console.WriteLine("Id is  " + id);
        }
        public new void print() {
            Console.WriteLine("derived class method");
        }
    }
    internal class Program {
        static void Main(string[] args) {
            A r;
            A t = new B();
            t.print();
            B b = new B("jay", 101);
            b.print();

            Console.Read();
        }
    }
}
