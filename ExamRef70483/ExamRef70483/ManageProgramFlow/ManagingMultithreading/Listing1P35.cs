using System;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ManagingMultithreading
{
    public class Listing1P35
    {
        /// <summary>
        /// The final value of n is not supposed to be 0 here
        /// </summary>
        public static void ShareDataInMultiThreadedOperation()
        {
            var n = 0;

            var up = Task.Run(() =>
            {
                for (var i = 0; i < 1000000; i++)
                {
                    n++;
                }
            });

            for (var i = 0; i < 1000000; i++)
            {
                n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
