﻿using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P67
    {
        public static void ForLoopWithBreakStatement()
        {
            int[] values = { 1, 2, 3, 4, 5, 6 };
            for (int index = 0; index < values.Length; index++)
            {
                if (values[index] == 4)
                {
                    break;
                }
                Console.WriteLine(values[index]);
            }
        }
    }
}