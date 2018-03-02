using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ManagingMultithreading
{
    public class Listing1P41
    {
        private static int _value = 1;

        /// <summary>
        /// The expected result should be zero because Increment and Decrement is atomic in nature.
        /// </summary>
        public static void ExchangeAsNonAtomic()
        {
            //Interlocked does this in atomic way
            //Interlocked.CompareExchange(ref _value, 2, 1);

            var t1 = Task.Run(() =>
            {
                if (_value != 1) return;
                Thread.Sleep(1000);
                _value = 2;
            });

            var t2 = Task.Run(() =>
            {
                _value = 3;
            });

            Task.WaitAll(t1, t2);
            Console.WriteLine(_value);
        }
    }
}