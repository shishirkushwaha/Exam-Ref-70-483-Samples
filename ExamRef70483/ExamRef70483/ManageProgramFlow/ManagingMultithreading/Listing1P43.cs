﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ManagingMultithreading
{
    public class Listing1P43
    {
        public static void ThrowingOperationCanceledException()
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

                token.ThrowIfCancellationRequested();

            }, token);

            try
            {
                Console.WriteLine("Press enter to stop Task");
                Console.ReadLine();
                cancellationTokenSource.Cancel();
                task.Wait();
            }
            catch (AggregateException ex)
            {
                Console.WriteLine(ex.InnerExceptions[0].Message);
            }

            Console.WriteLine("Press Enter to End Application");
            Console.ReadLine();
        }
    }
}