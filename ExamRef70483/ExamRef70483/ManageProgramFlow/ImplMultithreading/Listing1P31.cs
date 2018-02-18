using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P31
    {
        public static void EnumeratingConcurrentBag()
        {
            var bag = new ConcurrentBag<int> ();
            Task.Run(() =>
            {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });

            Task.Run(() =>
            {
                foreach (var i in bag)
                {
                    Console.WriteLine(i);
                }
            }).Wait();
        }
    }
}