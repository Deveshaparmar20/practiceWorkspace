using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private Singleton()
        {
            counter++;
            Console.WriteLine($"Counter : {counter.ToString()}");
        }
        //----------------Using lazy keyword (by default thread safe)---------
        private static readonly Lazy<Singleton> _instance = new Lazy<Singleton>(() => new Singleton());
        public static Singleton Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        //----------------Thread safe lazy instantiation-----------------------
        //private static Singleton _instance = null;
        //private static readonly object obj = new object();
        //public static Singleton Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //        {
        //            lock (obj)
        //            {
        //                if (_instance == null)
        //                    _instance = new Singleton();
        //            }
        //        }
        //        return _instance;
        //    }
        //}


    }
}
