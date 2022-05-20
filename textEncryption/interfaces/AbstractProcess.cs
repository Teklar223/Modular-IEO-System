namespace encryption_exercise
{
    public abstract class AbstractProcess
    {
        protected IEncryptor encryption_method;
        protected IInput input_method;
        protected IOutput output_method;

        public AbstractProcess(IEncryptor encryptor, IInput input, IOutput output)
        {
            this.encryption_method = encryptor;
            this.input_method = input;
            this.output_method = output;
        }
        public void Process(){
            try
            {
                string toEncrypt = input_method.input();
                encryption_method.encrypt(ref toEncrypt);
                output_method.output(ref toEncrypt);
            }
            catch(Exception e)
            {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine(e.Message);
                //this way to write out the error comes from https://docs.microsoft.com/en-us/dotnet/api/system.console.readline?view=net-6.0
            }
        }
        public virtual Boolean supportsAsync() { return false; } //false by default.
    }
}