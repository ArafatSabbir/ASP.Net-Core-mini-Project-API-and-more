using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpAtoZ
{
    class QueueInCsharp
    {
        static void Main(string[] args)
        {
            #region QueueInCsharp

            var q = new Queue();

            q.Enqueue("Sabbir");
            q.Enqueue("Jahid");
            q.Enqueue("Fahim");
            q.Dequeue(); // first item will removed


            foreach (Object o in q)
            {
                
                Console.WriteLine(o);
            }



            #endregion

        }


    }

}