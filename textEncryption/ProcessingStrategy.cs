namespace encryption_exercise
{
    public class ProcessingStrategy : aStrategy
    {

        override protected string Input() 
        {
            string? input = Console.ReadLine();
            if (input == null)
            {
                input = ""; //naturally, this still has 'no value'
            }
            return input; 
        }
        
    }

}