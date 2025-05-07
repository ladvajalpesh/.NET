using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class student
    {
        private int r_no;
        private string s_name;
        private int s_mark;

        public void display() {
            Console.WriteLine("student rollno: " +r_no);
            Console.WriteLine("student name:" + s_name);
            Console.WriteLine("student mark: " + s_mark);
        }

    public static void Main(string[] args) {
            student std = new student();
            std.r_no = 1;
            std.s_name = "haresh";
            std.s_mark = 75;
            std.display();
           
        }
    }
}