using System.IO;

namespace ExamRef70483.ManageProgramFlow.EventsAndCallBacks
{
    public class Listing1P77
    {
        public delegate TextWriter CovarienceDel();

        public static StringWriter MethodString()
        {
            {
                return null;
            }
        }

        public static StreamWriter MethodStream()
        {
            {
                return null;
            }
        }

        public static void UsingCovarianceDel()
        {
            CovarienceDel del;
            del = MethodStream;
            del += MethodString;
        }
    }
}