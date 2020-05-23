using System;

namespace CSharpAtoZ
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            while (count < 11)
            {
                Console.WriteLine($"{number} X {count} = {number*count}");
                count++;
            }
  

        }


    }
}

//Enter a number : 6
//6 X 1 = 6
//6 X 2 = 12
//6 X 3 = 18
//6 X 4 = 24
//6 X 5 = 30
//6 X 6 = 36
//6 X 7 = 42
//6 X 8 = 48
//6 X 9 = 54
//6 X 10 = 60







