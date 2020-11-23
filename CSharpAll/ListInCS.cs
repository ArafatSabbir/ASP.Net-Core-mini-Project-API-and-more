using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAll
{
    class ListInCS
    {
        static void Main(string[] args)
        {

            var myLi = new List<int>() { 1,2,3,4};
            var myLi2 = new List<int>() { 1, 2, 3, 4 };

            if (myLi == myLi2)
            {
                Console.WriteLine("Li 1 is Equal li 2. using ==");
            }


            if (myLi.SequenceEqual(myLi2))
            {
                Console.WriteLine("List 1 is Equal list 2.using Linq");
            }

        }
    }
}
