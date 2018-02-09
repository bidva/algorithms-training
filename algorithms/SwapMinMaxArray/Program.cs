using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapMinMaxArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 15, 22, 5, 7, 4, 12, 44, 11, 16, 2 };
            int[] res = SwapMinMaxArray(arr);
        }

        private static int[] SwapMinMaxArray(int[] arr)
        {
            int min = 0;
            int max = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[min] > arr[i])
                    min = i;
                if (arr[max] < arr[i])
                    max = i;
            }
            int temp = arr[min];
            arr[min] = arr[max];
            arr[max] = temp;
            return arr;
        }
    }
}
