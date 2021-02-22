using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAll
{
    public static class MyAlgorithms
    {
        public static int Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }

            else
            {
                return n * Factorial(n - 1);
            }
        }


        public static int Fibonacci(int n)
        {
            if (n==0)
            {
                return 0;
            }
            if (n == 1 || n == 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n-1)+ Fibonacci(n-2);
            }
        }
    }
}
