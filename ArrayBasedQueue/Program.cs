using System;
using System.Collections;

namespace ArrayBasedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayBasedQueue<int> Queue = new ArrayBasedQueue<int>();


            Console.WriteLine(Queue.IsArrayEmpty());

            for (int i = 0; i < 5; i++)
            {
                Queue.Enqueue(i);
            }

            Console.WriteLine(Queue.Peek());

            for (int i = 0; i < 5; i++)
            {
                Queue.Dequeue();
            }
           
        }
    }
}
