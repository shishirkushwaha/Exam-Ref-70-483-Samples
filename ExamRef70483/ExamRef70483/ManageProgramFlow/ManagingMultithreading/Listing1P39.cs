using System;
using System.Threading.Tasks;

namespace ExamRef70483.ManageProgramFlow.ManagingMultithreading
{
    public class Listing1P39
    {
        private static int _flag = 0;
        private static int _value = 0;

        public static void PotentialProblemMultithrading()
        {
            var t1 = new Task(Thread1);
            var t2 = new Task(Thread2);

            t1.Start();
            t2.Start();

            t2.Wait();
            t2.Wait();
        }

        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }

        public static void Thread2()
        {
            if (_flag == 1)
                Console.WriteLine(_value);
        }
    }
}