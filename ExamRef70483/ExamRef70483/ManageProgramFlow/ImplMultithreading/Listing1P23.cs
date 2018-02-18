using System;
using System.Linq;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P23
    {
        public static void UnOrderedParrelelQuery()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().WithExecutionMode(ParallelExecutionMode.ForceParallelism)
                .Where(i => i%2 == 0).ToArray();
            foreach (var i in parallelResult)
            {
                Console.WriteLine(i);
            }
        }
    }
}
