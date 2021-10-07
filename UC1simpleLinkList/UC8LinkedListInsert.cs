using System;
using System.Collections.Generic;

namespace UC8LinkedListInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddFirst(56);
            myList.AddFirst(30);
            myList.AddFirst(70);
            Console.Write("Before Inserting Number : ");
            foreach (object obj in myList)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            LinkedListNode<int> node = myList.Find(30);
            myList.AddAfter(node, 40);
            Console.Write("After Inserting Number : ");
            foreach (object obj in myList)
            {
                Console.Write(obj + " ");
            }
        }
    }
}
