namespace encryption_exercise
{
    public class WriteLineOutput : IOutput
    {
        public void output(ref string[] s)
        {
            Console.WriteLine("After Encrypting:");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("The "+i+"th row: " + s[i]);
            }
        }
    }
}