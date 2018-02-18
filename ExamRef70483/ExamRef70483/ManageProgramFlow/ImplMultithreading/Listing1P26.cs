using System;
using System.Linq;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P26
    {
        public static void UsingForAll()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().Where(i => i%2 == 0);
            parallelResult.ForAll(Console.WriteLine);
        }
    }
}
