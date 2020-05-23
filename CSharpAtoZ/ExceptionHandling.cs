using System;

namespace CSharpAtoZ
{
    class ExceptionHandling
    {
        static void Main(string[] args)
        {
            try
            {

                int[,] myArray =
                {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
                };

                Console.WriteLine("1st number of the array is : " + myArray[0, 0]);
                Console.WriteLine("Last number of the array is : " + myArray[4, 2]); // exception will occur here

            }


            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


    }
}

//Sample Output

//1st number of the array is : 1
//Index was outside the bounds of the array.







