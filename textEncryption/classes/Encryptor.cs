namespace encryption_exercise
{
    public class StringEncryptor : IEncryptor
    {
        public void encrypt(ref string s)
        {
            s = "Encrypted Text";
        }
    }
}