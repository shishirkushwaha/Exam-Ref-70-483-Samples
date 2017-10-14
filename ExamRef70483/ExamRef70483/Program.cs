using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Thread Proc : {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void CreatingThreadWithThreadClass()
        {
            var t = new Thread(ThreadMethod);
            t.Start();

            for (var i = 1; i < 4; i++)
            {
                Console.WriteLine("Main Thread : Do Some Work");
                Thread.Sleep(0);
            }

            t.Join();
        }
    }
}
