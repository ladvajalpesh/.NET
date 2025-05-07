//5.Write a program to give the example for method overriding concepts.
using System;

namespace oops_consept
{
    public class perent
    {
        public virtual void showmessege()
        {
            Console.WriteLine("mymethod");
        }

        public class child : perent
        {
            // @override
            public override void showmessege()
            {
                Console.WriteLine("mymethod2");
            }
        }
        internal class PrecticeQ5
        {
            public static void Main(string[] args)
            {

                child ch = new child();
                ch.showmessege();

                perent pr = new child();
                pr.showmessege();


            }
        }
    }
}
