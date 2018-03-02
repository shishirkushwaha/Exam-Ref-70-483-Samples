using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ManagingMultithreading
{
    public class Listing1P42
    {
        public static void UsingCancellationToken()
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
            }, token);

            Console.WriteLine("Press enter to stop Task");
            Console.ReadLine();
            cancellationTokenSource.Cancel();
        }
    }
}