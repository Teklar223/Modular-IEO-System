namespace encryption_exercise
{
    public class ReadLineInput : IInput
    {
        public string[] input()
        {

            string? value = Console.ReadLine();
            if (value == null)
            {
                value = "";
            }
            string[] input = new string[1];
            input[0] = value;
            return input; 
        }

        public Boolean isAsync()
        {
            return false;
        }
    }
}