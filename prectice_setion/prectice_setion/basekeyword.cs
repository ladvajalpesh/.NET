using System;

namespace prectice_setion {
    public class car {
        public int x; public int y;
        public car() {
            x = 10;
            y = 20;
            Console.WriteLine("x " + x + " y " + y);
        }

    }
    public class car1 : car {

        public car1() : base() {
            Console.WriteLine(x + y);
        }
    }
    internal class basekeyword {
        static void Main(string[] args) {
            car1 c = new car1();
            Console.Read();
        }
    }
}
