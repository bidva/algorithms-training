using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 3,9,4,2,6 };
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min_pos = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_pos])
                    {
                        min_pos = j;
                    }
                }
                int tmp = arr[i];
                arr[i] = arr[min_pos];
                arr[min_pos] = tmp;
            }
        }
    }
}
