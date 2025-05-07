using System;

namespace multiplefilerun {
    public class Person {
        public string Name { get; set; }
        public int age { get; set; }

        public void sleep() {
            Console.WriteLine("Sleeping");
        }
        public void eat() {
            Console.WriteLine("Eating");
        }

    }
}
