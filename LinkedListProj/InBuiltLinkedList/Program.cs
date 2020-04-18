using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListNewImp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            //list.AddToEnd(9);
            //list.AddToEnd(12);
            //list.AddToEnd(15);
            //list.AddToEnd(1);
            //list.AddToBeginning(9);
            //list.AddToBeginning(12);
            //list.AddToBeginning(15);
            //list.AddToBeginning(1);
            list.AddSorted(9);
            list.AddSorted(12);
            list.AddSorted(15);
            list.AddSorted(1);
            list.Print();
            Console.ReadKey();
        }
    }
}
