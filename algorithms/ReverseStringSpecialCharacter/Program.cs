using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseStringSpecialCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Ab,c,de!$";
            string res = revertString(str);
            Console.Write(res);
            Console.Read();
        }

        private static string revertString(string str)
        {
            char[] tmp = str.ToCharArray();
            int r = str.Length - 1;
            int l = 0;
            while (l<r)
            {
                if (!isAlphabet(tmp[l]))
                    l++;
                else if (!isAlphabet(tmp[r]))
                    r--;
                else
                {
                    swap(ref tmp[l], ref tmp[r]);
                    l++;
                    r--;
                }
            }
            return new string(tmp);
        }

        private static void swap(ref char v1, ref char v2)
        {
            char tmp = v1;
            v1 = v2;
            v2 = tmp;
        }

        private static bool isAlphabet(char v)
        {
            return ((v >= 'A' && v <= 'Z') || (v >= 'a' && v <= 'z'));
        }
    }
}
