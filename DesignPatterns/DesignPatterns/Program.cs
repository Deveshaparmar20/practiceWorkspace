using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj1 = Singleton.Instance;

            Singleton obj2 = Singleton.Instance;

            Console.ReadLine();
        }
    }
}
