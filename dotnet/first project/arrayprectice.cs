﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_project
{
    internal class arrayprectice
    {
        public static void Main(string[] args) { 
         int [] arr1 = new int[50];
            int[] arr2 = new int[50];
            int i, n;
            Console.WriteLine("enter the element to store in array");
            n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input {0} element in the array",n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);  
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
                for (i = 0; i < n; i++) {
                arr2[i] = arr1[i];
            }
            for (i = 0; i < n; i++) {
                Console.Write("{0} ", arr1[i]);
               
            }
            Console.WriteLine("\n\n");
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr2[i]);
            }
            Console.WriteLine("\n\n");

        }
    }
}
