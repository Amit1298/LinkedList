using System;

namespace UC3AppendLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UC3LinkedList List = new UC3LinkedList();
            List.Add(56);
            List.Add(30);
            List.Add(70);
            List.Display();
        }
    }
}
