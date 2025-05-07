using System;

namespace for_prectice
{
    internal class Pyramid
    {
        public static void Main(string[] arg)
        {
            int i;
            int j;
            for (i = 1; i <= 5; i++)
            {
                for (j = i; j <= 5; j++)
                {
                    Console.Write(" ");
                }
                for (j = 1; j <= (2 * i - 1); j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }


            // for useing background 
            /*  Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("hello");
                Console.ResetColor();

            // foreground is use to front color

                Console.foregroundColor = ConsoleColor.White;
                Console.WriteLine("hello");
                Console.ResetColor();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("hello");
                Console.ResetColor(); */

            /*
                //for using key values and modifiers show

                        Console.WriteLine("enter name");
                        ConsoleKeyInfo consolekey = Console.ReadKey();
                        Console.WriteLine("key is " + ConsoleKey.Add);
                        Console.WriteLine("modify" + consolekey.Modifiers);
                        Console.Read();*/
        }
    }
}
