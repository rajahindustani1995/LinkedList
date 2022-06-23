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

        public void AddNode(Node node)    //56 30 70
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.next = Head;
                Head = node;
            }

        }

        public void AppendNode(Node node)           // 70 30 56
        {
            if (Head == null && Tail == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.next = node;
                Tail = node;
            }
        }


        public void InsertNode(int value, int Previousvalue)
        {
            Node newNode = new Node(value);
            if (Head == null & Tail == null)
            {
                Head = newNode;
            }
            else
            {
                Node temp = Head;
                //Checking until temp variable data equal to the previous value of value to be added
                while (temp.data != Previousvalue)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }

        public void DeleteNodeAtFirst()
        {
            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = Head;
            
            Head = Head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }

        public void DeleteNodeAtLast()
        {

            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");

            }

            Node temp = Head;
            
            while (temp.next.next != null)
            {

                temp = temp.next;
            }
           
            temp.next = null;
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
