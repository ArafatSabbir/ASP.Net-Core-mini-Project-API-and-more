using System;

namespace CSharpAtoZ
{
    class MethodInCSharp
    {
        static void Main(string[] args)
        {

            PrintSomething("Sabbir", 23);
            PrintSomething("Fahim", 24);
            PrintSomething("Jahid", 25);

        }

        static void PrintSomething(string name, int age)
        {
            Console.WriteLine($"Name is {name} and age is {age}");
        }


    }
}


//Sample output


//Name is Sabbir and age is 23
//Name is Fahim and age is 24
//Name is Jahid and age is 25


