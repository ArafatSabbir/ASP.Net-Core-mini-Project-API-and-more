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

            myArrayList2.Insert(1,"Dubai");

            foreach (object o in myArrayList2)
            {
                Console.WriteLine(o);
            }


            ArrayList myArrayList3 = new ArrayList();
            myArrayList3.AddRange(myArrayList2);

            string[] myAr = (string[])myArrayList2.ToArray(typeof(string)); // conver into normal array


            #endregion

        }


    }

}