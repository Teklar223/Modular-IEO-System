
using System;
using System.IO;

namespace encryption_exercise
{
    public class Encryption
    {
        public void Encrypt(){
            try
            {
                string toEncrypt = Input();
                Console.WriteLine("Before Encrypting: " + toEncrypt);
                encrypt(ref toEncrypt);
                Output(ref toEncrypt);
            }
            catch(Exception e)
            {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine(e.Message);
                //this way to write out the error comes from https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=net-6.0
            }
        }

        protected virtual string Input() 
        {
            string? input = Console.ReadLine();
            if (input == null)
            {
                input = ""; //naturally, this still has 'no value'
            }
            return input; 
        }
        protected virtual void encrypt(ref string s) { s = "Encrypted"; /* TODO - Implement a basic encyption */}
        protected virtual void Output(ref string s) { Console.WriteLine("After Encrypting: " + s); }
        
    }

}