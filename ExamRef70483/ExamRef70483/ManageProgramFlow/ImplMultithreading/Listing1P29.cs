using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P29
    {
        public static void UsingGetConsumingEnumerable()
        {
            var col = new BlockingCollection<string>();

            var read = Task.Run(() =>
            {
                foreach (var v in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(v);
                }
            });

            var write = Task.Run(() =>
            {
                while (true)
                {
                    var s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) { break; }
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}