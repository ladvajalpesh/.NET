using System;

namespace encapsulation_prectice
{
    public class person
    {
        public string name { get; set; }
        public int age { get; set; }

        public void sleep()
        {
            Console.WriteLine("sleeping");
        }

        public void eat()
        {
            Console.WriteLine("eating");
        }

        public void display()
        {
            Console.WriteLine("name is: " + name);
            Console.WriteLine("age is: " + age);
        }
    }
}
