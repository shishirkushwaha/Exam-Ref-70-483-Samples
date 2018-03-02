using System;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ManagingMultithreading
{
    public class Listing1P45
    {
        public static void SettingATimeOutOnTask()
        {
            var longRunningTask = new Task(() =>
            {
                Thread.Sleep(10000);
            });

            var index = Task.WaitAny(new[] { longRunningTask }, 1000);
            if (index == -1)
            {
                Console.WriteLine("Long Running Task Timed Out");
            }
        }
    }
}