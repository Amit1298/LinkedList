using System;
using System.Collections;

namespace UC5abilityToDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();

            myStack.Push(70);
            myStack.Push(30);
            myStack.Push(56);
            Console.Write("Before Number Deleted: ");
            foreach (object obj in myStack)
            {
                Console.Write(obj + " ");
            }

            Console.WriteLine();
            myStack.Pop();
            Console.Write("After Number Deleted: ");
            foreach (object obj in myStack)
            {
                Console.Write(obj + " ");
            }
        }
    }
}
