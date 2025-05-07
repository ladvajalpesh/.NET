//1. Write a program create a class ‘simpleobject‘. Using constructor display the message.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_consept
{
    public class simpleobject
    {
        public simpleobject()
        {
            Console.WriteLine("This is a simple object");
        }
    }
    internal class precticQ1
    {
        public static void Main(string[] arg) { 
         simpleobject sim = new simpleobject();
            
        }
    }
}
