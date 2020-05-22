
using System;

namespace CSharpAtoZ
{
    class StringManipulations
    {
        static void Main(string[] args)
        {
            string name = "Sabbir Ahmed";
            string name1 = "Jahidul Islam";
            string name2 = "Fahim foysal";


            Console.WriteLine("My name is " + name);
            Console.WriteLine("My friend first name is " + name1.Substring(0, 5));
            Console.WriteLine("My another friend name start with " + name2[0]);
        }
    }
}


