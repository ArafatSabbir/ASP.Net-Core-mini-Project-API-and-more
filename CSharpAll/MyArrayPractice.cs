using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CSharpAll
{
    class MyArrayPractice
    {
        static void Main(string[] args)
        {
            
            ///2D array
            
            int[,] arr =
            {
                {1,2,3,4},
                {8,5,6,7},
                {9,11,22,33}
            };
            Console.WriteLine(arr[2,2]);


            ///random  array

            int[][] arr2 =
            {
                new int[] {1,2,3,4},
                new int[] {8,5,6,7,22,44,55,77},
                new int[] {9,11,33}
            };
            Console.WriteLine(arr2[2] [2]);


        }

        
        

    }
}
