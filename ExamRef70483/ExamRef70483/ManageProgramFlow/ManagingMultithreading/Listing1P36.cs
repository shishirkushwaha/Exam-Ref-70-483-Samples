using System;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ManagingMultithreading
{
    public class Listing1P36
    {
        /// <summary>
        /// This example solves the issues of n not getting 0 in Listing1P35
        /// </summary>
        public static void UsingLockKeyword()
        {
            var n = 0;
            var _lock = new object();

            var up = Task.Run(() =>
            {
                for (var i = 0; i < 1000000; i++)
                {
                    lock(_lock)n++;
                }
            });

            for (var i = 0; i < 1000000; i++)
            {
                lock(_lock)n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
