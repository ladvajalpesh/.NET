//Define Polymorphism with an example. Create a Shape class with a method Area(),
//and derive Rectangle and Circle classes that override the method.
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_prectice
{
    internal class precticeQ4
    {
        public class shape {
            public virtual void area() {
                Console.WriteLine("Area of shape is 10*10=100");
            }
        }
        public class rectangle : shape
        {
            public override void area()
            {
                Console.WriteLine("Area of rectangle is 10*20=200");
            }
        }
        public class circle : shape {
                public override void area()
        {
            Console.WriteLine("Area of circle is 3.14*10*10=314");
        }
            }
        static void Main(String[] args) { 
         circle c = new circle();
            c.area();
        }
    }
}
