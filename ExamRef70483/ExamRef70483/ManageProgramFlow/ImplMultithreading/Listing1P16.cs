using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P16
    {
        /// <summary>
        /// This method just took 2 seconds to Execute. And that depicts that Parallel processing
        /// is executing the loops asynchronously.
        /// </summary>
        public static void UsingParallerForForeach()
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
            });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
            });
        }
    }
}