using System;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P12
    {
        public static void AddChildTaskToParentTask()
        {
            var parent = Task.Run(() =>
            {
                var results = new int[3];
                new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
                new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();

                return results;
            });

            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (var i in parentTask.Result)
                {
                    Console.WriteLine("From Child Tasks : {0}", i);
                }
            });

            finalTask.Wait();
        }
    }
}