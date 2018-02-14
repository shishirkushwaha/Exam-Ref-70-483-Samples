using System;
using System.Threading;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P6
    {
        public static ThreadLocal<int> Field = new ThreadLocal<int>(() => Thread.CurrentThread.ManagedThreadId);

        public static void UsingThreadLocal()
        {
            new Thread(() =>
            {
                for (var i = 0; i < Field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0}", i);
                }
            }).Start();

            new Thread(() =>
            {
                for (var i = 0; i < Field.Value; i++)
                {
                    Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}