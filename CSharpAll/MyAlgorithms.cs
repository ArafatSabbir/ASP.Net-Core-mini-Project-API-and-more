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

        public static object BinarySearchIterative(int[] inputArray, int key)
        {
            int left = 0;
            int right = inputArray.Length - 1;

            while (left <= right)
            {
                int mid = left + ((right- left) / 2);

                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return "Not found or Array is unsorted";
        }
    }
}
