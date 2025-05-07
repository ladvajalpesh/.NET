
using System;

namespace encapsulation_prectice {
    internal class Program {
        static void Main(string[] args) {
            Person person = new Person();
            person.Name = "John Doe";
            person.Age = 30;
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("age:" + person.Age);

            Console.Read();
        }
    }
}
