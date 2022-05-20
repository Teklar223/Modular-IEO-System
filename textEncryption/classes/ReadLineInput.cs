namespace encryption_exercise
{
    public class ReadLineInput : IInput
    {
        public string input()
        {
            string? input = Console.ReadLine();
            if (input == null)
            {
                input = "";
            }
            return input; 
        }
    }
}