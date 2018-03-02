using System;
using System.Collections.Concurrent;

namespace ExamRef70483.ManageProgramFlow.ImplMultithreading
{
    public class Listing1P34
    {
        public static void UsingConcurrentDictionary()
        {
            var dict = new ConcurrentDictionary<string, int>();
            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }

            //Checks if Current Value is equal to Existing Value
            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("21 updates to 42");
            }

            dict["K1"] = 42; //Overrite Unconditionally

            //Make sure an itent is added if its not there
            var r1 = dict.AddOrUpdate("k1", 3, (s, i) => i * 2);
            var r2 = dict.GetOrAdd("k2", 3);
        }
    }
}