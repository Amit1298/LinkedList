using System;
using System.Collections;

namespace UC4abilityInsert
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList MyList = new ArrayList();
            MyList.Add(56);
            MyList.Add(70);
            Console.Write("Before Inserting value: ");
            foreach (object arr in MyList)
            {
                Console.Write(arr + " ");
            }
            Console.WriteLine();
            MyList.Insert(1, 30);
            Console.Write("After Inserting value: ");
            foreach (object arr in MyList)
            {
                Console.Write(arr + " ");
            }
        }
    }
}
