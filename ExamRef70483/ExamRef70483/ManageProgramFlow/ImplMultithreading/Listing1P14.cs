using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P14
    {
        public static void UsingTaskWaitAll()
        {
            var tasks = new Task[3];

            tasks[0] = new Task<int>(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1");
                return 1;
            });

            tasks[1] = new Task<int>(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2");
                return 2;
            });
            
            tasks[2] = new Task<int>(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("3");
                return 3;
            });

            Task.WaitAll(tasks);
        }
    }
}