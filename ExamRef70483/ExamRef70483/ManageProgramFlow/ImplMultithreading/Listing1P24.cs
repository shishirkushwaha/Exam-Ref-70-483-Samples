using System;
using System.Linq;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P24
    {
        public static void OrderedParrelelQuery()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i%2 == 0).ToArray();
            foreach (var i in parallelResult)
            {
                Console.WriteLine(i);
            }
        }
    }
}
