using System;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P11
    {
        public static void DifferentContinuationTask()
        {
            var t = Task.Run(() => 42);
            t.ContinueWith((i) => Console.WriteLine("Cancelled"), TaskContinuationOptions.OnlyOnCanceled);
            t.ContinueWith((i) => Console.WriteLine("Faulted"), TaskContinuationOptions.OnlyOnFaulted);
            var completedTask = t.ContinueWith((i) => Console.WriteLine("Completed"), TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
        }
    }
}