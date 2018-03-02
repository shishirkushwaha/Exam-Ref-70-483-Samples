using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P48
    {
        public static void ShortCircuitingOrOperator()
        {
            var x = true;
            var result = x || GetY();
            Console.WriteLine(result);
        }

        private static bool GetY()
        {
            Console.WriteLine("This Method Doesn't get called");
            return true;
        }
    }
}