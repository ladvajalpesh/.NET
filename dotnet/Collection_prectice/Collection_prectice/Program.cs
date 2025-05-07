using System;
using System.Collections;
using System.Collections.Generic;

namespace Collection_prectice {
    internal class Program {
        static void Main(string[] args) {

            ArrayList td = new ArrayList();// non- generica
            td.Add(1);
            td.Add("hello");
            td.Add(2.5);
            td.RemoveAt(1);
            foreach (object obj in td) {
                Console.WriteLine(obj);
            }

            List<string> lt = new List<string>();// generica
            lt.Add("hello");
            lt.Add("world");
            // lt.Add(1); its a type cheking 
            foreach (var obj1 in lt) {
                Console.WriteLine(obj1);
            }

            Console.Read();

        }
    }
}
