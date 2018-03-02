using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P51
    {
        public static void UsingTheXorOperator()
        {
            const bool a = true;
            const bool b = false;
            Console.WriteLine(a ^ a);
            Console.WriteLine(a ^ b);
            Console.WriteLine(b ^ b);
        }
    }
}