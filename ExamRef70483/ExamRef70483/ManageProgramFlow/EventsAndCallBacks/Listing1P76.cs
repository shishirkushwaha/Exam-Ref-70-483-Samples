using System;

namespace ExamRef70483.ManageProgramFlow.EventsAndCallBacks
{
    public class Listing1P76
    {
        public delegate void Del();

        public static void MethodOne()
        {
            Console.WriteLine("Method One");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("Method Two");
        }

        public static void MulticastDelegate()
        {
            Del d = MethodOne;
            d += MethodTwo;

            d();
        }
    }
}