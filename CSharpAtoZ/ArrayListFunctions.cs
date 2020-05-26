using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpAtoZ
{
    class ArrayListFunctions
    {
        static void Main(string[] args)
        {
            #region Simple Array List

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("Sabbir");
            myArrayList.Add("Fahim");
            myArrayList.Add("Jahid");
            myArrayList.Add("Saifur");

            myArrayList.Remove("Saifur");

            foreach (object o in myArrayList)
            {
                Console.WriteLine(o);
            }

            ArrayList myArrayList2 = new ArrayList();

            myArrayList2.AddRange(myArrayList);

            myArrayList2.AddRange(new object[] {"Bangladesh", "Nepal" , "Bhutan"  });

            myArrayList2.Sort();

            myArrayList2.Reverse();

            foreach (object o in myArrayList2)
            {
                Console.WriteLine(o);
            }



            #endregion

        }


    }

}