namespace encryption_exercise
{
    public abstract class AbstractProcess
    {
        /// <summary>
        /// AbstractProcess defines a class with a Template method called Process(),
        /// Which always executes 3 strategies in the same order, Resembling a Pipeline.
        /// </summary>
        protected IEncryptor encryption_method;
        protected IInput input_method;
        protected IOutput output_method;

        public void set_encryption_method(IEncryptor newEncryptor) { this.encryption_method = newEncryptor; }
        public void set_input_method(IInput newInput) { this.input_method = newInput; }
        public void set_output_method(IOutput newOutput) { this.output_method = newOutput; }

        public AbstractProcess(IEncryptor encryptor, IInput input, IOutput output)
        {
            /// <summary>
            /// Receives 3 objects, which indicate the strategy to use at every step of the Process.
            /// input specifies how to receive information.
            /// encryptor specifies how to encrypt that information.
            /// output specifies how to output the encrypted information.
            /// </summary>
            this.encryption_method = encryptor;
            this.input_method = input;
            this.output_method = output;
        }
        public void Process()
        {
            /// <summary>
            /// Activates the input, encryption, output strategies in that order.
            /// </summary>
            /// <value></value>
            try
            {
                string[] toEncrypt = input_method.input();
                encryption_method.encrypt(ref toEncrypt);
                output_method.output(ref toEncrypt);
            }
            catch (Exception e)
            {
                TextWriter errorWriter = Console.Error;
                errorWriter.WriteLine(e.Message);
            }
        }
        public virtual Boolean supportsAsync()
        {
            /// <summary>
            /// Checks if the input method is Async safe.
            /// </summary>
            /// <returns> True if the Input method is Async safe, Otherwise False. </returns>
            return this.input_method.isAsync();
        }
    }
}