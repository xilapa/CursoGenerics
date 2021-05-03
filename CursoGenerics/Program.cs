using CursoGenerics.Circular_Buffer;
using CursoGenerics.EqualityComparer;
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

            #region Yield Return
            // Display powers of 2 up to the exponent 8:
            foreach (int i in Power(2, 8))
            {
                if (i > 16) break;
                Console.Write("{0} ", i);
            }

            static IEnumerable<int> Power(int number, int exponent)
            {
                int counter = 0;
                int result = 1;
                while (counter++ < exponent)
                {
                    result = result * number;
                    yield return result;
                }
            }
            #endregion

            #region IEqualityComparer

            var departments = new SortedDictionary<string, SortedSet<Employee>>();

            departments.Add("Sales", new SortedSet<Employee>(new EmployeeComparer()));
            departments["Sales"].Add(new Employee { Name = "Juliana" });
            departments["Sales"].Add(new Employee { Name = "Dirceu" });

            departments.Add("Engineering", new SortedSet<Employee>(new EmployeeComparer()));
            departments["Engineering"].Add(new Employee { Name = "Geraldo" });
            departments["Engineering"].Add(new Employee { Name = "Geraldo" });

            Console.WriteLine("\n\n");
            foreach (var department in departments)
            {
                Console.WriteLine(department.Key);
                foreach (var employee in department.Value)
                {
                    Console.WriteLine($"\t{employee.Name}");
                }
            }

            #endregion
        }
    }
}
