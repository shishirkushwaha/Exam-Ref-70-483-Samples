using System;
using System.Threading;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P7
    {
        public static void QueueWorkToThreadPool()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from Threadpol");
            });
        }
    }
}