//2. Write a program for the following 1. Example for call by value. 2. Example for call by reference.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_consept
{
    public class simpleobject1
    {
        int num;
        //call by value
 
    }
    public class callbyreference 
    {
        public void callbyref(ref int num)
        {
            num = num + 10;
            Console.WriteLine("Value of num is: " + num);
        }
    }
    public class precticeQ2
    {
        public static void Main(string[] arg)
        {
            simpleobject simobj = new simpleobject();
       
        }
    }
}
