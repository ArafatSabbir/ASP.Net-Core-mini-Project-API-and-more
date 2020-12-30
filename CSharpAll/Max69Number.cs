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

////Given a positive integer num consisting only of digits 6 and 9.

////    Return the maximum number you can get by changing at most one digit (6 becomes 9, and 9 becomes 6).

 

////    Example 1:

////Input: num = 9669
////Output: 9969
////Explanation:
////Changing the first digit results in 6669.
////    Changing the second digit results in 9969.
////    Changing the third digit results in 9699.
////    Changing the fourth digit results in 9666. 
////    The maximum number is 9969.
