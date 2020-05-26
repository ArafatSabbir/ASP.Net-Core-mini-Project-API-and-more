using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpAtoZ
{
    class StackInCsharp
    {
        static void Main(string[] args)
        {
            #region StackInCsharp

            var stack = new Stack();

            stack.Push("Fahim");
            stack.Push("Sabbir");
            stack.Push("Jahid");
            stack.Pop();
            stack.Pop();



            foreach (Object o in stack)
            {
                
                Console.WriteLine(o);
            }



            #endregion

        }


    }

}