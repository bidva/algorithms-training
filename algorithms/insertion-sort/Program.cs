using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 10, 3, 2, 4 };
            Console.WriteLine("Before: 5, 10, 3, 2, 4");
            int newValue;
            for (int i = 0; i < nums.Length; i++)
            {
                newValue = nums[i];
                int j = i;
                while (j>0&& nums[j-1]>newValue)
                {
                    nums[j] = nums[j - 1];
                    j--;
                }
                nums[j] = newValue;
            }
            Console.Write("Array after sort: ");
            for (int k = 0; k < nums.Length; k++)
            {
                Console.Write("{0}, ", nums[k]);
            }
            Console.ReadLine();
        }
    }
}
