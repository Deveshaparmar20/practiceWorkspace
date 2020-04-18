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
            //Tree tree = new Tree(10);
            //tree.Add(14);
            //tree.Add(92);
            //tree.Add(80);
            //tree.Add(99);
            //tree.Add(16);
            //tree.Add(99);
            //tree.Add(0);
            //tree.Add(90);
            //tree.Add(8);
            //tree.Add(12);
            //string s = string.Empty;
            //tree.PrintRev(null, ref s);
            //Console.WriteLine(s);
            NodeDeletion tree = new NodeDeletion();
            tree.insert(50);
            tree.insert(30);
            tree.insert(20);
            tree.insert(40);
            tree.insert(70);
            tree.insert(60);
            tree.insert(80);

            Console.WriteLine("Inorder traversal of the given tree");
            tree.inorder();

            Console.WriteLine("\nDelete 20");
            tree.deleteKey(20);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.inorder();

            Console.WriteLine("\nDelete 30");
            tree.deleteKey(30);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.inorder();

            Console.WriteLine("\nDelete 50");
            tree.deleteKey(50);
            Console.WriteLine("Inorder traversal of the modified tree");
            tree.inorder();
            Console.ReadKey();
        }
    }
}
