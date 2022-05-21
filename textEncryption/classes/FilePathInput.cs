namespace encryption_exercise
{
    public class FilePathInput : IInput // https://stackoverflow.com/questions/4220993/c-sharp-how-to-convert-file-readlines-into-string-array
    {
        public string[] input()
        {
            string path = "files/demofile.txt";
            string[] input = System.IO.File.ReadAllLines(path);

            /* DEBUG - prints out the text and then waits for any user input before continuing (NOT Async) */
            /*
            System.Console.WriteLine("Contents of writeLines2.txt =:");
            foreach (string line in input)
            {
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
            */
            /* DEBUG */

            return input;
        }

        public Boolean isAsync()
        {
            return true;
        }
    }
}