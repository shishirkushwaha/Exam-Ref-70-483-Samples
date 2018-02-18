using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P28
    {
        public static void UsingBlockingCollection()
        {
            var col = new BlockingCollection<string>();
            var read = Task.Run(() =>
            {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            });

            var write = Task.Run(() =>
            {
                while (true)
                {
                    var s = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(s)) { break;}
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}