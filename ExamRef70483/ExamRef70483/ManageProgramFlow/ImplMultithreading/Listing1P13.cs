using System;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P13
    {
        public static void UsingTaskFactory()
        {
            var parent = new Task<int[]>(() =>
            {
                var results = new int[3];
                var tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => results[0] = 0);
                tf.StartNew(() => results[1] = 1);
                tf.StartNew(() => results[2] = 2);

                return results;
            });

            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (var i in parentTask.Result)
                {
                    Console.WriteLine("From Parent Task : {0}", i);
                }
            });

            finalTask.Wait();
        }
    }
}