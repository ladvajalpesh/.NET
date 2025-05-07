using System;

namespace sealedclass_program {
    sealed class box {
        public void sealedbox() {
            Console.WriteLine("box is sealedbox");
        }
    }
    partial class student {
        public string stud_name { get; set; }

    }
    partial class student {
        public void displayname() {
            Console.WriteLine($"student name is:-{stud_name}");
        }
    }


    internal class Program {
        static void Main(string[] args) {
            box b = new box();
            b.sealedbox();
            student s = new student();
            s.stud_name = "John";
            s.displayname();

            Console.Read();
        }
    }
}
