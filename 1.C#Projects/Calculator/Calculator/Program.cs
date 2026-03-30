using System;

namespace Calculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello this is my first Calculator");
            Console.WriteLine("           Enjoy !!!");

            Console.WriteLine("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("+");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=");
            Console.WriteLine(num1 + num2);
            
            Console.ReadLine();
        }
    }
}
