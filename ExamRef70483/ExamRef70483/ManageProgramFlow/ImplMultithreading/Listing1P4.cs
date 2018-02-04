using System;
using System.Threading;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P4
    {
        public static void ThreadMethod(object o)
        {
            for (var i = 0; i < (int) o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void UsingAbortThread()
        {
            var stopped = false;

            var t = new Thread(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(500);
                }
            });

            t.Start();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

            stopped = true;
            t.Join();
        }
    }
}