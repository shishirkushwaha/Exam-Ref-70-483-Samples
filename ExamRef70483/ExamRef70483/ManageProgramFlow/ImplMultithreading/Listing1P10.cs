using System;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P10
    {
        public static void AddTaskContinuation()
        {
            var t = Task.Run(() => 42).ContinueWith((i) => i.Result * 2);
            Console.Write("Result after contiuation : {0}", t.Result);
        }
    }
}