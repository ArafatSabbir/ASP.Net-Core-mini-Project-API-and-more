using System;

namespace CSharpAtoZ
{
    class FunWithNumbers
    {
        static void Main(string[] args)
        {
            int a = 5, b= 6 ,c = a+b;
            double x = 3.30;


            Console.WriteLine("Sum of a and b is " + c);
            Console.WriteLine("Square of 6 is "+Math.Pow(b,2));
            Console.WriteLine("Round of x is " + Math.Round(x));
        }
    }
}
