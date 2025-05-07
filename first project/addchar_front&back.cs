using System;

namespace first_project
{
    internal class addchar_front_back
    {
        public static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the string: ");
            str = Console.ReadLine();
            if (str.Length >= 1)
            {
                var s = str.Substring(0, 1);
                Console.WriteLine(s + str + s);

            }
        }

    }
}
