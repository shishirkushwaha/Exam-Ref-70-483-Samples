using System;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P8
    {
        public static void StartANewTask()
        {
            var t = Task.Run(() =>
            {
                for (var i = 0; i < 100; i++)
                {
                    Console.Write("*");
                }
            });

            t.Wait();

            Console.ReadKey();
        }
    }
}