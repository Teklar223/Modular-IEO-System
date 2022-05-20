namespace encryption_exercise
{
    public abstract class aStrategy
    {
        public void Process(){
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
            string input = "Abstract Text";
            return input; 
        }
        protected virtual void encrypt(ref string s) { s = "Encrypted Text"; /* TODO - Implement a basic encyption */}
        protected virtual void Output(ref string s) { Console.WriteLine("After Encrypting: " + s); }
    }
}