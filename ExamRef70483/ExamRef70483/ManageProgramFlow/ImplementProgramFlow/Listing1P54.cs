namespace ExamRef70483.ManageProgramFlow.ImplementProgramFlow
{
    public class Listing1P54
    {
        public static void CodeBLockAndScoping()
        {
            var b = true;
            if (b)
            {
                int r = 42;
                b = false;
            }

            //r is not accessiable
            //b is now false
        }
    }
}