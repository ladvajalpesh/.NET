
using System;

namespace access_specifiers {

    static class  A {
        public int num1;
        public int num2;

        public void Add() {
            Console.WriteLine("Addition is: " + (num1 + num2));
        }
    }


    internal class statickeyword {
        static void Main(string[] args) {
          A.num1 = 10;
            A.num2 = 20;
            A.Add();



            Console.Read();
        }
    }
}
