using System;
using System.Threading;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P5
    {
        [ThreadStatic]
        public static int Field;

        public static void UsingThreadStaticAttribute()
        {
            new Thread(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    Field++;
                    Console.WriteLine("Thread A: {0}", Field);
                }
            }).Start();

            new Thread(() =>
            {
                for (var i = 0; i < 10; i++)
                {
                    Field++;
                    Console.WriteLine("Thread B: {0}", Field);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}