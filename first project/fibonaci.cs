using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class fibonaci
    {
        public static void Main(string[] args) {
            int a = 0;
            int b = 1;
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++) {
                int temp = a + b;
                a = b;
                b = temp;
                Console.WriteLine(temp);
            }
        }
    }
}