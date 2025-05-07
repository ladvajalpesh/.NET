//3.Write a program to give the example for ‘this’ operator. And also use the ‘this’ keyword as
//return statement.

using System;

namespace oops_consept
{
    public class example
    {
        public int num;

        public example(int num)
        {
            this.num = num;

        }
        public void setnum(int num)
        {
            this.num = num;
        }
        public example getnum(int num)
        {

            return this;
        }
        public void display()
        {
            Console.WriteLine("number is :" + this.num);
        }
    }
    internal class precticeQ3
    {
        public static void Main(string[] args)
        {

            example ex = new example(50);
            ex.display();
        }

    }
}
