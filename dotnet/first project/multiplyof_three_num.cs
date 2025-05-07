using System;

namespace first_project
{
    internal class multiplyof_three_num
    {
        public static void Main(string[] agrs)
        {
            int num1, num2, num3;
            Console.WriteLine("enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter third number");
            num3 = Convert.ToInt32(Console.ReadLine());

            int multiplication = num1 * num2 * num3;
            Console.WriteLine("total is: " + multiplication);
        }
    }
}
