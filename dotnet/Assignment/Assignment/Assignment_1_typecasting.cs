using System;

namespace Assignment
{
    internal class Assignment_1_typecasting
    {
        static void Main(string[] args)
        {
            // type Conversion (Implicit Type Conversion)

            char ch = 'A';
            int N = ch;
            Console.WriteLine("Convert char to int values"+N);
            int num = 100;
            long lg = num;
            Console.WriteLine("Convert int to long values:"+ lg);
            float fl = lg;
            Console.WriteLine("Convert long to float values" + fl);
            Double d = fl;
            Console.WriteLine("Convert float to Double values"+d); 

            // explicit type casting 

            int number = 100;
            char n = (char)number;

            Console.WriteLine(n);

            // conevrt method used
           double dl = 12000.00;
            Console.WriteLine("convert double to int:" + Convert.ToInt32(dl));
            long l = Convert.ToInt32(dl);
            Console.WriteLine("convert double to long"+l);
            int i = Convert.ToInt32(l);
            Console.WriteLine("convert long to int "+ i);
            Char c = 'A';
            Console.WriteLine("convert char to int :"+Convert.ToInt32(c));
            
            
        }
    }
}
