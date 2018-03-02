using System;

namespace ExamRef70483.ManageProgramFlow.EventsAndCallBacks
{
    public class Listing1P75
    {
        public delegate int Calculate(int x, int y);

        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static void UseADelegate()
        {
            Calculate calc = Add;
            Console.WriteLine(calc(4, 3));

            calc = Multiply;
            Console.WriteLine(calc(4, 3));
        }
    }
}