using System;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P17
    {
        public static void UsingParallelBreak()
        {
            var result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop.");
                    loopState.Break();
                }
                return;
            });
        
            Console.WriteLine("Loop IsCompleted : {0}", result.IsCompleted);
            Console.WriteLine("Loop LowestBreakIteration : {0}", result.LowestBreakIteration);          
        }
    }
}