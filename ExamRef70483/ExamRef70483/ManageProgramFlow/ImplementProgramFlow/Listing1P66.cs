using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P66
    {
        public static void ForLoopWithCustomIncrement()
        {
            int[] values = {1, 2, 3, 4, 5, 6};
            for (int index = 0; index < values.Length; index += 2)
            {
                Console.WriteLine(values[index]);
            }
        }
    }
}