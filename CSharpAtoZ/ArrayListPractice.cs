using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpAtoZ
{
    class ArrayListPractice
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


            #endregion

        }


    }

}