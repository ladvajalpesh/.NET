//type casting in c#.there are two types of type casting in c#.
// 1) implicit type casting.
using System;
class implicit_typecasting
{
     public static void Main(string[] args)
     {
          int i = 100;
          double d=i;
         System.Console.WriteLine(i);
          System.Console.WriteLine(d);
     }
}




//2)explicit type casting.
class explicit_typecasting {
     public static void Main(string [] args){
          double d = 120.25;
          int i=(int) d ;
          System.Console.WriteLine(d);
          System.Console.WriteLine(i);
     }
}