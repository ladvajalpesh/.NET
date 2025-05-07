using System;
using encapsulation_prectice; 

namespace encapsulation_prectice
{
    internal class Program  
    {
        public static void Main(string[] args)
        {
            person p = new person();
            p.name = "sachin";
            p.age = 25;
            p.display();
            p.eat();
            p.sleep();
        }
    }
}
