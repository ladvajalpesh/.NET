using System;

namespace lecture040425 {

    public class Program2 {
        public static int x;
        public static int y;
        static Program2() {
            x = 100;
            y = 200;

        }
        public static void display() {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }

    }

    internal class Program {
        static void Main(string[] args) {
            Program2.display();

        }
    }
}

