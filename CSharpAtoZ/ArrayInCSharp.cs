using System;

namespace CSharpAtoZ
{
    class ArrayInCSharp
    {
        static void Main(string[] args)
        {
            int[] myArray = {1,2,3,4,5,6};
            string[] myStringArray = new string[5];

            for(int i = 0; i < 5; i++) 
            {
                Console.Write("Enter a name : ");
                myStringArray[i] = Console.ReadLine();
                Console.WriteLine($"Name is {myStringArray[i]} and id is {myArray[i]}");
            }
            
        }
    }
}




//sample output

//    Enter a name : sabbir
//Name is sabbir and id is 1
//Enter a name : jahid
//Name is jahid and id is 2
//Enter a name : fahim
//Name is fahim and id is 3
//Enter a name : tanim
//Name is tanim and id is 4
//Enter a name : biplob
//Name is biplob and id is 5
