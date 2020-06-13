using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProj
{
    public class LinkedList
    {
        private Node head;
        public int count { get; set; }

        public LinkedList()
        {
            head = null;
            count = 0;
        }

        public bool Empty { get { return count == 0; } }

        public object Add(int index, object O)
        {
            if (index < 0)
                throw new ArgumentOutOfRangeException();
            if (index > count)
                index = count;
            Node current = head;
            if (Empty || index == 0)
                head = new Node(O, head);
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.next;
                current.next = new Node(O, current.next);             
            }
            count++;
            return O;
        }

        public object Add(object O)
        {
            return Add(count, O);
        }

    }
}
