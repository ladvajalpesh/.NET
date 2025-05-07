using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class table
    {
        public static void Main()
        {
            int num;
            Console.WriteLine("enter the number");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
               int table = num * i;
                Console.WriteLine($"{0} * {1} = {2}",num,i , table);
            }
        }
    }
}
