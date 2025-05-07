using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class factorial
    {
   
        public static void Main(string[] args) {
            int fact=1;
            Console.WriteLine("enter the number");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
                fact = fact * i;
            Console.WriteLine(fact);

        }
    }
}
