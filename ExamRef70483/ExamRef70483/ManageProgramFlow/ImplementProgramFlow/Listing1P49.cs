using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P49
    {
        public static void UsingTheAndOperator()
        {
            var value = 42;
            var result = (0 < value) && (value < 100);
            Console.WriteLine(result);
        }
    }
}