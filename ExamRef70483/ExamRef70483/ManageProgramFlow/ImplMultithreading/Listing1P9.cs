using System;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P9
    {
        public static void TaskThatReturnsAValue()
        {
            var t = new Task<int>(() => 42);
            Console.WriteLine(t.Result);
        }
    }
}