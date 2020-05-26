using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpAtoZ
{
    class DictionaryInCSharp
    {
        static void Main(string[] args)
        {
            #region Simple Array List

            var Dict = new Dictionary<int, String>();

            Dict.Add(1, "Sabbir");
            Dict.Add(2, "Jahid");
            Dict.Add(3, "Fahim");






            foreach (KeyValuePair<int,string> o in Dict)
            {
                Console.Write($" key : {o.Key} || value : ");
                Console.WriteLine(o.Value);
                Console.WriteLine("-------------------------");
            }



            #endregion

        }


    }

}