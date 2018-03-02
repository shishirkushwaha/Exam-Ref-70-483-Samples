namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P57
    {
        public static void ReadableNestedIfStatement()
        {
            const bool b = false;
            const bool c = true;

            if (b)
            {
                if (c)
                {
                    F();
                }
                else
                {
                    G();
                }
            }
        }

        private static void F()
        {

        }

        private static void G()
        {

        }
    }
}