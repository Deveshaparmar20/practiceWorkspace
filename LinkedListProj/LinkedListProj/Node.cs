using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProj
{
    public class Node
    {
        private object data { get; set; }
        public Node next { get; set; }

        public Node (object data, Node next)
        {
            this.data = data;
            this.next = next;
        }
    }
}
