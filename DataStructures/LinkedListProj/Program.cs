using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProj
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add("test1");
            list.Add("test2");
            list.Add("test3");
            list.Add("test4");
            list.Add(2, "test5");
        }
    }
}
