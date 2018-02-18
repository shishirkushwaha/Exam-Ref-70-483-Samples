using System;
using System.Linq;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P27
    {
        public static void CatchingAggregateException()
        {
            var numbers = Enumerable.Range(0, 20);

            try
            {
                var parallelResult = numbers.AsParallel().Where(IsEven);
                parallelResult.ForAll(Console.WriteLine);
            }
            catch (AggregateException ex)
            {
                Console.WriteLine("There were {0} aggregate exceptions.", ex.InnerExceptions.Count);
            }
        }

        public static bool IsEven(int i)
        {
            if (i % 10 == 0)
            {
                throw new ArgumentException("i");
            }

            return i % 2 == 0;
        }
    }
}