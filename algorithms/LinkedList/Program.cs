using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            Console.WriteLine("Is it empty? - " + list.Empty);
            Console.WriteLine("Count - " + list.Count);
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add(2, "4");
            list.Add(2, "5");
            int index1 = list.IndexOf("2");
            bool contains1 = list.Contains("2");
            list.Remove(1);
            int index2 = list.IndexOf("2");
            bool contains2 = list.Contains("2");

            object tmp1 = list.Get(3);
            object tmp2 = list[1];

            list.Clear();
            Console.ReadLine();


        }
    }
}
