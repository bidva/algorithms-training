using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num;
            string unsortedArray = "";
            string sortedArray = "";
            num = rnd.Next(0, 100);
            unsortedArray = unsortedArray + num.ToString().PadLeft(3);
            Tree myTree = new Tree(num);
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                num = rnd.Next(0, 100);
                unsortedArray = unsortedArray + num.ToString().PadLeft(3);
                myTree.AddRc(num);
            }
            string treeString = "";
            myTree.Print(null, ref treeString);
            Console.WriteLine(treeString);
            Console.ReadKey();

        }
    }
}
