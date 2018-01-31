using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoIntSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 2, 3,5,6,4,67,51,8,12 };
            bool tmp = TwoIntSum(arr, 55);
            Console.WriteLine(tmp);
            Console.Read();
        }

        private static bool TwoIntSum(int[] arr, int value)
        {
            arr = arr.OrderBy(x => x).ToArray();
            int p1 = 0;
            int p2 = arr.Length-1;
            while (p1 < p2)
            {
                int sum = arr[p1] + arr[p2];
                if (sum == value)
                {
                    return true;
                }
                else if (sum > value)
                {
                    p2--;
                }
                else
                {
                    p1++;
                }
            }
            return false;
        }
    }
}
