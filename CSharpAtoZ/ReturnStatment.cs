using System;

namespace CSharpAtoZ
{
    class ReturnStatment
    {
        static void Main(string[] args)
        {
            int num = 8;
            Console.WriteLine(Qube(num));

        }

        static int Qube(int number)
        {
            int result = number * number * number;
            return result;
        }


    }
}


//Sample output

// 512


