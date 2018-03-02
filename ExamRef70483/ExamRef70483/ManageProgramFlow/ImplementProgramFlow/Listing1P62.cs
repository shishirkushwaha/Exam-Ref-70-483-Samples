using System;

namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P62
    {
        public static void CheckWithSwitch()
        {
            var input = Console.ReadKey();
            Check(input.KeyChar);
        }

        public static void Check(char input)
        {
            switch (input)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                {
                    Console.WriteLine("Input is vowel");
                    break;
                }
                case 'y':
                {
                    Console.WriteLine("Input is sometimes a vowel.");
                    break;
                }
                default:
                {
                    Console.WriteLine("Input is consonant");
                    break;
                }
            }
        }
    }
}