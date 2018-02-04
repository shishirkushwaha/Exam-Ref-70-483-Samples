using System;
using System.Threading;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P2
    {
        public static void ThreadMethod()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void UsingBackgroundThread()
        {
            var t = new Thread(ThreadMethod)
            {
                //If this is true the application exists immediately, 
                //because the application do not wait for the background thread to complete.
                IsBackground = false
            };
            t.Start();
        }
    }
}