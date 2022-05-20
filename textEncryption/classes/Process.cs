namespace encryption_exercise
{
    public class Process : AbstractProcess
    {
        public Process(IEncryptor encryptor, IInput input, IOutput output) : base(encryptor, input, output){}
        
    }

}