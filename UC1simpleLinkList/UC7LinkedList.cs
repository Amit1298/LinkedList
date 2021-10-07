using System;
using System.Collections.Generic;

namespace UC7LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(56);
            myList.AddFirst(30);
            myList.AddFirst(70);
            LinkedListNode<int> node = myList.Find(30);
            myList.AddAfter(node, 50);
            myList.AddBefore(node, 40);
            Console.WriteLine("Show the Number: ");
            foreach (object obj in myList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
