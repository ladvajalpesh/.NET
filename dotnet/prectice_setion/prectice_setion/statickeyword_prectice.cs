using System;

namespace prectice_setion {

    static class sum {
        public static int a;
        public static int b;

        static sum() {

            Console.WriteLine(" a:- " + a + " b:- " + b);
        }

        public static int add() {
            return a + b;

        }
    }
    public class sub {
        public int x = 10;
        public int y = 20;

        public sub() {

            Console.WriteLine(" x:- " + x + " y:- " + y);
        }
        public int subtraction() {
            return x - y;
        }
    }


    internal class statickeyword_prectice {
        static void Main(string[] args) {
            //sum a = new sum();
            sum.a = 10;
            sum.b = 20;
            Console.WriteLine("sum of a and b is " + sum.add());


            sub s = new sub();

            s.subtraction();
            Console.WriteLine("substraction is " + s.subtraction());


            Console.Read();
        }
    }
}
