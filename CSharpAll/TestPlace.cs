using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpAll
{
    public class TestPlace
    {
        static void Main(string[] args)
        {
            int[] unSortedArr = {2, 10, 1, 6, 3, 5, 7, 12, 8 };
            int[] sortedArr = {1, 2, 3, 5, 6, 7, 8, 10, 12};
           
            int[] res = MyAlgorithms.BubbleSort(arr: unSortedArr);
            foreach (int a in res)
            {
                Console.Write($"{a} ");
            }
        }
    }
}
