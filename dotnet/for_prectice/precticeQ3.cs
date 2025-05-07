//What is Inheritance in C#? Create a base class Animal with a method MakeSound(),
//then derive a Dog class that overrides the method.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace for_prectice
{ 
    internal class precticeQ3
    {
        public class animal {
            string sound;

            public void  SoundPlayer() { 
                Console.WriteLine("Animal Sound");
            }
        
        }

        public class dog : animal 
        {
            
          public void SoundPlayer()
            {
                Console.WriteLine("break");
            }

        }
        static void Main(string[] args) {
            dog d = new dog();
            d.SoundPlayer();
        }
    }
}
