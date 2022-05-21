using System.Security.Cryptography;
namespace encryption_exercise
{
    public class StringEncryptor : IEncryptor
    {
        public void encrypt(ref string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = Encrypt(ref s[i]);
            }
        }

        private string Encrypt(ref string s) //https://www.delftstack.com/howto/csharp/encrypt-and-decrypt-a-string-in-csharp/
        {
            try
            {
                string textToEncrypt = s;
                string ToReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";
                byte[] secretkeyByte = { };
                secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms;
                CryptoStream cs;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}