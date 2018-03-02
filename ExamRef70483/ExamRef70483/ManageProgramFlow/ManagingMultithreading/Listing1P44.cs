using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ManagingMultithreading
{
    public class Listing1P44
    {
        public static void AddingContinuationForCancelledTasks()
        {
            var cancellationTokenSource = new CancellationTokenSource();
            var token = cancellationTokenSource.Token;

            var task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }

            }, token).ContinueWith((t) =>
            {
                if (t.Exception != null) { t.Exception.Handle((e) => true); }
                Console.WriteLine("You have cancelled the Task");

            }, TaskContinuationOptions.OnlyOnCanceled);

            Console.WriteLine("Press enter to stop Task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();
            task.Wait();

            Console.WriteLine("Press Enter to End Application");
            Console.ReadLine();
        }
    }
}