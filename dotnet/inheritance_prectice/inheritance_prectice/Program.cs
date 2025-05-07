//1️⃣ Create a base class Animal with a method MakeSound()
//and derive a class Dog from it. Override MakeSound() in Dog to print "Dog barks".
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_prectice
{
    internal class Program
    {
        public class animal {
            public virtual void makesound()
            {
                Console.WriteLine("Animal makes sound");
            }

        }
        public class dog : animal
        {
            public override void makesound()
            {
                Console.WriteLine("Dog barks");
            }
        }
        static void Main(string[] args)
        {
           animal d = new dog();
            d.makesound();
            animal a = new animal();
            a.makesound();
        }
    }
}
