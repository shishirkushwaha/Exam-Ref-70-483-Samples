using System;
using System.Collections.Concurrent;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P32
    {
        public static void UsingConcurrentStack()
        {
            var stack = new ConcurrentStack<int>();
            stack.Push(42);

            int result;
            if (stack.TryPop(out result)) { Console.WriteLine("Popped: {0}", result); }

            stack.PushRange(new int[] { 1, 2, 3, 4, 5 });
            var values = new int[2];

            if (stack.TryPopRange(values) >= 1)
            {
                foreach (var i in values)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}