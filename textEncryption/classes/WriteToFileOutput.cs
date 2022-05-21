namespace encryption_exercise
{
    public class WriteToFileOutput : IOutput
    {
        public void output(ref string[] s)
        {
            string path = "files/encrypted_demofile.txt";
            File.WriteAllLines(path, s);
        }
    }
}