using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Node
    {
        public int value;
        public Node left;
        public Node right;
        public Node(int initial)
        {
            value = initial;
            left = null;
            right = null;
        }
    }
    class Tree
    {
        Node top;
        public Tree()
        {
            top = null;
        }
        public Tree(int Initial)
        {
            top = new Node(Initial);
        }
        public void Add(int value)
        {
            AddR(ref top, value);
        }
        private void AddR(ref Node N, int value)
        {
            if (N == null)
            {
                Node newNode = new Node(value);
                N = newNode;
                return;
            }
            if (value < N.value)
            {
                AddR(ref N.left, value);
                return;
            }
            if (value >= N.value)
            {
                AddR(ref N.right, value);
                return;
            }
        }

        public void Print(Node N, ref string S)
        {
            if (N == null) { N = top; }
            if(N.left!=null)
            {
                Print(N.left, ref S);
                S += N.value.ToString().PadLeft(3);
            }
            else
            {
                S += N.value.ToString().PadLeft(3);
            }
            if (N.right != null)
            {
                Print(N.right, ref S);
            }
        }

        public void PrintRev(Node N,ref string S)
        {
            if (N == null) { N = top; }
            if (N.right != null)
            {
                PrintRev(N.right, ref S);
                S += N.value.ToString().PadLeft(3);
            }
            else
            {
                S += N.value.ToString().PadLeft(3);
            }
            if (N.left != null)
            {
                PrintRev(N.left, ref S);
            }
        }
    }
}
