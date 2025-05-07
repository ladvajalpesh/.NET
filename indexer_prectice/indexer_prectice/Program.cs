using System;

namespace indexer_prectice {
    public class Student {
        private string[] names = new string[10];
        int age;
        public string this[int index] {
            get {
                return names[index];
            }
            set {
                if (value != null) {
                    names[index] = value;
                }
                else {
                    Console.WriteLine("Invalid value");
                }
            }
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }
        internal class Program {
            static void Main(string[] args) {
                Student student = new Student();
                student[0] = "ram";
                student[1] = "shyam";
                Console.WriteLine(student[0]);
                Console.WriteLine(student[1]);
                Console.Read();
            }
        }
    }
}
