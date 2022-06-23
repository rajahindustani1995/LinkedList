using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    internal class LinkedList
    {
        public Node Head;
        public Node Tail;


        public LinkedList()
        {
            Head = null;
            Tail = null;
        }


        internal void Display()
        {
            Node temp = Head;
            if (temp == null)
                Console.WriteLine("Linked List is empty");
            else
                Console.WriteLine("Linked List");
            while (temp != null)
            {
                Console.Write(temp.data);
                if (temp.data != null)
                    Console.Write("->");
                temp = temp.next;
            }
        }
    }
}
