using System;
using System.Collections.Concurrent;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P33
    {
        public static void UsingConcurrentQueue()
        {
            var queue = new ConcurrentQueue<int>();
            queue.Enqueue(42);

            int result;
            if (queue.TryDequeue(out result))
            {
                Console.Write("Dequeued : {0}", result);
            }
        }
    }
}