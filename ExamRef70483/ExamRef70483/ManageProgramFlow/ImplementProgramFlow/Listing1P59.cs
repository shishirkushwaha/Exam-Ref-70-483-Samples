namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P59
    {
        public static void NullCoalescingOperator()
        {
            int? x = null;
            int? z = null;
            var y = x ??
                    z ??
                    -1;
        }
    }
}