//4.Create class named as ‘a’ and create a sub class ‘b’. Which is extends from class ‘a’. And use
//these classes in ‘inherit’ class.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_consept
{
    public class  A
    {
        public void mymethod() { 
            Console.WriteLine("This is a base class");
        }
    }

    public class B: A
    {
        public void mymethod1()
        {
            Console.WriteLine("This is  B sub class");
        }   
    }
    internal class PrecticeQ4
    {
        public static void Main(string[] args)
        {
            B b = new B();
            b.mymethod1();

        }
    }
}
