
using System;

namespace CSharpAtoZ
{
    class ArrayInCSharp
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6 };
            string[] myStringArray = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter a name : ");
                myStringArray[i] = Console.ReadLine();
                Console.WriteLine($"Name is {myStringArray[i]} and id is {myArray[i]}");
            }

        }
    }
}




