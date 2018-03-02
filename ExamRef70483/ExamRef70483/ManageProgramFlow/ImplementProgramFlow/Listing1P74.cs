using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P74
    {
        public static void GotoStatementWithALabel()
        {
            int x = 3;
            if (x == 3)
            {
                goto customLabel;
            }

            x++;
        customLabel:
            Console.WriteLine(x);
        }
    }
}