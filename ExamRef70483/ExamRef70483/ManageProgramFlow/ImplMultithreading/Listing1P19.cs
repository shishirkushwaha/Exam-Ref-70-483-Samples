using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P19
    {
        public Task SleepAsyncA(int millisecondsTimeOut)
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeOut));
        }

        public Task SleepAsyncB(int millisecondsTimeOut)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeOut, -1);
            return tcs.Task;
        }
    }
}