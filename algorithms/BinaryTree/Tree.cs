using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    public class Tree
    {
        Node top;
        public Tree()
        {
            top = null;
        }
        public Tree(int i)
        {
            top = new Node(i);
        }
        public void Add(int value)
        {
            if (top == null)
            {
                Node newNode = new Node(value);
                top = newNode;
                return;
            }
            Node currentNode = top;
            bool added = false;
            do
            {
                if (value < currentNode.value)
                {
                    if (currentNode.left == null)
                    {
                        Node NewNode = new Node(value);
                        currentNode.left = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.left;
                    }
                }
                else
                {
                    if (currentNode.right == null)
                    {
                        Node NewNode = new Node(value);
                        currentNode.right = NewNode;
                        added = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }

            } while (!added);

        }
        public void AddRc(int value)
        {
            AddR(ref top, value);
        }
        private void AddR(ref Node N, int value)
        {
            if (N == null)
            {
                Node NewNode = new Node(value);
                N = NewNode;
                return;
            }
            if (value < N.value)
            {
                AddR(ref N.left, value);
                return;
            }
            else
            {
                AddR(ref N.right, value);
                return;
            }
        }
        public void Print(Node N, ref string s)
        {
            if (N == null)
            {
                N = top;

            }
            if (N.left != null)
            {
                Print(N.left, ref s);
                s = s + N.value.ToString().PadLeft(3);
            }
            else
            {
                s = s + N.value.ToString().PadLeft(3);
            }
            if (N.right != null)
            {
                Print(N.right, ref s);
            }
        }
    }
}
