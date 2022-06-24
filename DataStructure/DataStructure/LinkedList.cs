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

        public void DeleteFirstNode()
        {
            if (Head == null & Tail == null)
            {
                Console.WriteLine("Nothing to delete list is empty");
            }
            Node temp = Head;
            
            Head = Head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }

        public void DeleteLastNode()
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
        internal void Search(int value)
        {
            Node tempHead = Head;

            int position = 1;

            if (Head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (tempHead.next != null)
            {
                
                if (tempHead.data == value)
                {
                    Console.WriteLine("Value " + value + " is found at position " + position);
                }
                tempHead = tempHead.next;
                position++;
            }
        }

        internal void InsertNewNode(int value, int data)
        {
            Node tempHead = Head;
            Node newNode = new Node(data);

            if (Head == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }

            while (tempHead.next != null)
            {
                //If our desired value is found in the list after which we want to insert our node
                if (tempHead.data == value)
                {
                    Console.WriteLine(newNode.data + " is inserted after " + tempHead.data);
                    newNode.next = tempHead.next;
                    tempHead.next = newNode;
                    break;
                }
                tempHead = tempHead.next;
            }
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
