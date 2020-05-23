using System;

namespace CSharpAtoZ
{
    class TwoDarray
    {
        static void Main(string[] args)
        {
            int[,] myArray =
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };

            Console.WriteLine("1st number of the array is : " + myArray[0, 0]);
            Console.WriteLine("Last number of the array is : " + myArray[2,2]);

        }


    }
}








