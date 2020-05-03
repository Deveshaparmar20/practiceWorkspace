using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdjacencyLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter file name");
            string file = Console.ReadLine();
            Graph g = new Graph(@"C:\PersonalSourceCode\LinkedListProj\AdjacencyLinkedLists\" + file);
            g.dfs();
            Console.ReadLine();
        }
    }
}
