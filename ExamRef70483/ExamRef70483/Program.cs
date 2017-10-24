using System;
using System.Threading;
using ExamRef70483.AddOn.Generics;

namespace ExamRef70483
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int>.Test();
            Console.ReadLine();
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