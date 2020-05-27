using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpAtoZ
{
    class HashTableInCSharp
    {
        static void Main(string[] args)
        {
            #region HashTableInCSharp

            var hashTable = new Hashtable();

            hashTable.Add("Name","Sabbir");
            hashTable.Add("Id", 33);
            hashTable.Add("Country", "Bangladesh");
            hashTable.Add("E-mail", "Sabbir@sabbir.com");





            foreach (Object o in hashTable.Keys)
            {
                
                Console.WriteLine(o +"-" +hashTable[o]);
            }



            #endregion

        }


    }

}