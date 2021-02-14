using System;

namespace CSharpAll
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
        public void ReverseString(char[] s)
        {
            int len = s.Length;
            char[] fn = new char[len];
            int i = 0;
            while (i < len / 2)
            {
                fn[i] = s[len - 1 - i];
                fn[len - 1 - i] = s[i];
                i++;
            }
            if (len % 2 == 1) 
                fn[i] = s[i];

            return String.Join("",fn);
        }



    }
}
