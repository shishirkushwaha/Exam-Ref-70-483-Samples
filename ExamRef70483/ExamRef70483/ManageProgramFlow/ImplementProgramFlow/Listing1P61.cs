using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P61
    {
        public static void ComplexIfStatement()
        {
            var input = Console.ReadKey();
            Check(input.KeyChar);
        }

        public static void Check(char input)
        {
            if (input == 'a' ||
                input == 'e' ||
                input == 'i' ||
                input == '0' ||
                input == 'u')
            {
                Console.WriteLine("Input {0} is a vowel", input);
            }
            else
            {
                Console.WriteLine("Inpout {0} is an Consonent", input);
            }

        }
    }
}