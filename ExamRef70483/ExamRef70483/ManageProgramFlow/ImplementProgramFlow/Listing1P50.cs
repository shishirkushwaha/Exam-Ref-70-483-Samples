using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P50
    {
        public static void UsingTheAndOperator()
        {
            Console.WriteLine("Enter an Input");
            var input = Console.ReadLine();
            Process(input);
        }

        public static void Process(string input)
        {
            var result = (input != null) && (input.StartsWith("v"));
            Console.WriteLine("The condition that input is not null and it starts from \"v\" is : {0}", result);
        }
    }
}