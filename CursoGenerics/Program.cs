using CursoGenerics.Circular_Buffer;
using System;
using System.Collections.Generic;

namespace CursoGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList
            Console.WriteLine("Linked List Example");
            var linkedList = new LinkedList<int>();

            linkedList.AddFirst(1);
            linkedList.AddFirst(2);

            var firstNode = linkedList.First;
            linkedList.AddAfter(firstNode, 10);
            linkedList.AddBefore(firstNode, 9);

            firstNode = linkedList.First;
            while (firstNode is not null)
            {
                Console.WriteLine(firstNode.Value);
                firstNode = firstNode.Next;
            }
            Console.WriteLine("-----");
            #endregion

            #region Dictionary
            Console.WriteLine("Dictionary Example");
            var dictionary = new Dictionary<string, int>();
            dictionary.Add("um", 1);
            dictionary.Add("dois", 2);
            dictionary.Add("três", 3);

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }
            #endregion
        }
    }
}
