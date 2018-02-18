using System;
using System.Collections.Concurrent;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P30
    {
        public static void UsingConcurrentBag()
        {
            var bag = new ConcurrentBag<int> { 42, 21 };

            int result;
            if (bag.TryTake(out result)) { Console.WriteLine(result); }

            if (bag.TryPeek(out result)) { Console.WriteLine("There is a next item {0}", result); }
        }
    }
}