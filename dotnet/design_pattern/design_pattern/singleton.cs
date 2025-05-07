using System;
using design_pattern;

namespace design_pattern {
    sealed class Myclass
    {
        private Myclass() { }
        private static Myclass instance;
        private static object instancelock = new object(); //instance lock 
        public static Myclass Getinstance()
        {
            if (instance == null)
            {
                lock (instancelock)
                {
                    if (instance == null)
                    {
                        instance = new Myclass();
                    }
                }
            }
            return instance;
        }

        public void Display()
        {
            Console.WriteLine("Singleton class");
        }
    }

    public class secondclass{

        public void print()
        {
            Console.WriteLine("second class method");
        }
    }
}
    internal class singleton {
    static void Main(string[] args) {
        Myclass obj = Myclass.Getinstance();
        Myclass obj1 = Myclass.Getinstance();
        obj.Display();
        obj1.Display();
        // secondclass obj2 = Myclass.Getinstance();
        //obj2.print();
        Console.Read();
    }
}

