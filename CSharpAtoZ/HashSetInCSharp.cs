using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpAtoZ
{
    class HashSetInCSharp
    {
        static void Main(string[] args)
        {
            #region HashSetInCSharp

            var hashSet = new HashSet<string>();

            hashSet.Add("Sabbir");
            hashSet.Add( "33");
            hashSet.Add("Bangladesh");
            hashSet.Add("Sabbir@sabbir.com");
            hashSet.Add("Bangladesh");
            hashSet.Add("Bangladesh");





            foreach (Object o in hashSet)
            {
                
                Console.WriteLine(o );
            }



            #endregion

        }


    }

}