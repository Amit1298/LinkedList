using System;
using System.Collections.Generic;
using System.Text;

namespace UC2createLinkedList
{
    public class UC2LinkedList
    {
        internal UC2Node head;
        internal void Add(int data)
        {
            UC2Node node = new UC2Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                UC2Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Linked List ", node.data);
        }
        internal void Display()
        {
            UC2Node temp = this.head;
            if (temp == null)
            {
                Console.Write("Linked List is empty : ");
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
