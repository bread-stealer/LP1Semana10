using System;
using System.Collections.Generic;

namespace IntCollections
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int[] values = {1, 10, -30, 10, -5};

            List<int> list = new List<int>();
            foreach (int v in values) list.Add(v);
            Console.WriteLine("List: " + string.Join(", ", list));

            Stack<int> stack = new Stack<int>();
            foreach (int v in values) stack.Push(v);
            Console.WriteLine("Stack: " + string.Join(", ", stack));

            Queue<int> queue = new Queue<int>();
            foreach (int v in values) queue.Enqueue(v);
            Console.WriteLine("Queue: " + string.Join(", ", queue));

            HashSet<int> hashSet = new HashSet<int>();
            foreach (int v in values) hashSet.Add(v);
            Console.WriteLine("HashSet: " + string.Join(", ", hashSet));
        }
    }
}
