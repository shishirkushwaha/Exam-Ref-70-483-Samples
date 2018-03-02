namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P60
    {
        public static void TheConditionalOperator()
        {
            GetValue(true);
        }

        public static int GetValue(bool p)
        {
            if (p)
            {
                return 1;
            }
            else
            {
                return 0;
            }

            return p ? 1 : 0;
        }
    }
}