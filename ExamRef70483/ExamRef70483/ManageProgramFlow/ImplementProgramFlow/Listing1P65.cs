using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P65
    {
        public static void ForLoopWithMultipleLoopVariable()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int x = 0, y = values.Length - 1; (x < values.Length) && (y >= 0); x++, y--)
            {
                Console.WriteLine(values[x]);
                Console.WriteLine(values[y]);
            }
        }
    }
}