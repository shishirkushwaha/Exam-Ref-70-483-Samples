using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P68
    {
        public static void ForLoopWithContinueStatement()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (var index = 0; index < values.Length; index++)
            {
                if (values[index] == 4)
                {
                    continue;
                }
                Console.WriteLine(values[index]);
            }
        }
    }
}