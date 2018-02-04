using System;
using System.Threading;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    internal class Listing1P3
    {
        public static void ThreadMethod(object o)
        {
            for (var i = 0; i < (int) o; i++)
            {
                Console.WriteLine("ThreadProc {0}", i);
            }
        }

        public static void UsingParameterizedThread()
        {
            var t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}
