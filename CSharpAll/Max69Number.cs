using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpAll
{
    class Max69Number
    {
        static void Main(string[] args)
        {
            Max69Number obj = new Max69Number();
            Console.WriteLine(obj.Max69number(6699));
        }

        public int Maximum69Number(int num)
        {
            var charArray = num.ToString().ToCharArray();
            for (int idx = 0; idx < charArray.Length; idx++)
                if (charArray[idx] == '6')
                {
                    charArray[idx] = '9';
                    break;
                }

            return int.Parse(new string(charArray));
        }


        public int Max69number(int num)
        {
            return int.Parse(new Regex("6").Replace(num.ToString(), "9", 1));
        }

    }
}
