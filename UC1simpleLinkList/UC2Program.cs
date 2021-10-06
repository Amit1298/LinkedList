using System;

namespace UC2createLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UC2LinkedList List = new UC2LinkedList();
            List.Add(30 + 70);
            List.Add(30);
            List.Add(56 + 70);
            List.Display();
        }
    }
}
