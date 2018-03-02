using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ManagingMultithreading
{
    public class Listing1P40
    {
        /// <summary>
        /// The expected result should be zero because Increment and Decrement is atomic in nature.
        /// </summary>
        public static void UsingInterlockedClass()
        {
            var n = 0;

            var up = Task.Run(() =>
            {
                for (var i = 0; i < 10000000; i++)
                {
                    Interlocked.Increment(ref n);
                }
            });

            for (var i = 0; i < 10000000; i++)
            {
                Interlocked.Decrement(ref n);
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}