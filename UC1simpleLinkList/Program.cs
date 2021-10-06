using System;

namespace UC1simpleLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            LinkedList List = new LinkedList();
            List.Add(56);
            List.Add(30);
            List.Add(70);
            List.Display();
        }
    }
}
