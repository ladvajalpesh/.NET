using System;

namespace prectice_setion {
    public class Person {


        public int Std_id;
        public int Std_age;
        public Person() {
            Console.WriteLine("defual constructor");

        }

        public Person(int Std_id, int std_age) {

            this.Std_id = Std_id;
            this.Std_age = std_age;
        }


        public void setStd_id(int std_id) {
            this.Std_id = std_id;
        }
        public int getStd_id() {
            return Std_id;
        }
        public void setStd_age(int std_age) {
            this.Std_age = std_age;
        }
        public int getStd_age() {
            return Std_age;
        }
    }
    internal class Program {
        static void Main(string[] args) {
            Person person1 = new Person();
            Person person = new Person(1, 20);

            person.setStd_id(1);
            person.setStd_age(20);

            Console.WriteLine("Id: " + person.getStd_id());
            Console.WriteLine("Age: " + person.getStd_age());
            Console.Read();
        }
    }
}

