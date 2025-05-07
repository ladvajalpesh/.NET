using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_consept
{
    public class student
    {
        string name;
        int age;
        //creating default constructor
        public student() {
            Console.WriteLine("defualt constructer:");
        }
        //creating one parameterized constructor
        public student(string name)
        {
            this.name = name;
        }
        //creating two parameterized constructor
        public student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //diplay the info of student
        public void display()
        {
            Console.WriteLine(" name " + name+ "\n" + "age" + age);
        }
    }
    internal class consturcter
    {
        
        static void Main(string[] args)
        {
            student s1 = new student("Rahul");//calling one parameterized constructor
            student s2 = new student("Rahul", 25);//calling two parameterized constructor
            s1.display();//display one paramertized constructor
            s2.display();//display two paramertized constructor
        }
    }
}
