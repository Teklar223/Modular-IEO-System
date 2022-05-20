namespace encryption_exercise
{
    public class WriteLineOutput : IOutput
    {
        public void output(ref string s)
        {
            Console.WriteLine("After Encrypting: " + s);
        }
    }
}