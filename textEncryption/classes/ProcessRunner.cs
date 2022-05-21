using System.Threading;

// https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/creating-and-throwing-exceptions

namespace encryption_exercise
{
    public class ProcessRunner
    {
        public void execute(AbstractProcess process)
        {
            /// <summary>
            /// Executes a specific process in a *Synchronised* way, does NOT throw.
            /// </summary>
            process.Process();

        }
        public void executeAsync(AbstractProcess process)
        {
            /// <summary>
            /// Executes a specific process in an *Async* way, THROWS an exception if Async is NOT SUPPORTED by the process.
            /// </summary>
            if (process.supportsAsync())
            {
            Thread t = new Thread(new ThreadStart(process.Process));
            t.Start();
            }
            else
            {
                throw new InvalidOperationException("Do dont run synced functions using an async method.");
            }
        }
    }
}