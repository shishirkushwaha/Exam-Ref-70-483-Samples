using System;
using System.Linq;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P22
    {
        public static void UsingAsParallel()
        {
            var numbers = Enumerable.Range(0, 100000000);
            var parallelResult = numbers.AsParallel().Where(i => i%2 == 0).ToArray();
            Console.WriteLine(parallelResult[0] + " : " + parallelResult[parallelResult.Length - 1]);
        }
    }
}
