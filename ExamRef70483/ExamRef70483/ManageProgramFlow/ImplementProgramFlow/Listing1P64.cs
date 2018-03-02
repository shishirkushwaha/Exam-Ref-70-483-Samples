using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P64
    {
        public static void BasicForLoop()
        {
            int[] values = {1, 2, 3, 4, 5, 6};
            for (int index = 0; index < values.Length; index++)
            {
                Console.WriteLine(values[index]);
            }
        }
    }
}