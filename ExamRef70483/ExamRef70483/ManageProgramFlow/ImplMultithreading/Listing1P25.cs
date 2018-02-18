using System;
using System.Linq;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P25
    {
        public static void ParellerQuerySequential()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(i => i%2 == 0).AsSequential();
            
            foreach (var i in parallelResult.Take(5))
            {
                Console.WriteLine(i);
            }
        }
    }
}
