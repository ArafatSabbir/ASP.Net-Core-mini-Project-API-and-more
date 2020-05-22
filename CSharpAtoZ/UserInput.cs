using System;

namespace CSharpAtoZ
{
    class UserInput
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            
            Console.WriteLine($"Sum of {a} and {b} is " + Math.Pow(a,b));
            
        }
    }
}
