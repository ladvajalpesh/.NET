using System;
namespace prectice_setion {
    public class k {
        public int a;
        public int b;
        public void print(ref int a, out int b) {
            a = a+5;
            b = 10;
        }
    }
    internal class outkeyword {
        static void Main() {
            k  k = new k();
           int x = 5;
            int y;
            k.print(ref x, out y);
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.Read();

        }
    }
}















































































