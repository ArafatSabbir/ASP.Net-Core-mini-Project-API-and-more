using System;

namespace CSharpAtoZ
{
    class StaticClass
    {
        static void Main(string[] args)
        {
            Tools.PrintSomething("Bangladesh");
        }


    }

    static class Tools
    {
        public static void PrintSomething( string text)
        {
            Console.WriteLine("Use passed text is \"" + text + "\"");
        }


    }
}


//Sample output

//Use passed text is "Bangladesh"








