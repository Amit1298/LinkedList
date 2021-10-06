using System;
using System.Collections.Generic;
using System.Text;

namespace UC3AppendLinkedList
{
    public class UC3LinkedList
    {
        internal UC3Node head;
        internal void Add(int data)
        {
            UC3Node node = new UC3Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                UC3Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List", node.data);
        }
        internal void Display()
        {
            UC3Node temp = this.head;
            if (temp == null)
            {
                Console.Write("Linked List is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
