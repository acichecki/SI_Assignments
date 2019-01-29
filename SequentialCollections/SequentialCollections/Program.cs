using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace SequentialCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();

            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            queue.Enqueue("Fourth");

            foreach (var ele in queue)
            {
                Console.WriteLine(ele.ToString());
            }

            while (queue.Count != 0)
            {
                queue.Dequeue();
            }

            Console.WriteLine();

            Stack stack = new Stack();

            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");
            stack.Push("Fourth");

            foreach (var ele in stack)
            {
                Console.WriteLine(ele.ToString());
            }

            while (stack.Count != 0)
            {
                stack.Pop();
            }

            Console.ReadKey();
        }
    }
}
