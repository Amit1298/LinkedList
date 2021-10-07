using System;
using System.Collections.Generic;

namespace UC9LinkedListDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddLast(56);
            myList.AddLast(30);
            myList.AddLast(40);
            myList.AddLast(70);
            Console.WriteLine("Before Deleted element: ");
            foreach (int num in myList)
            {
                Console.Write(num + " ");
            }


            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            LinkedListNode<int> node = myList.Find(40);
            myList.Remove(node);
            Console.WriteLine("After Deleted element:");
            foreach (int num in myList)
            {
                Console.Write(num + " ");
            }
        }
    }
}
