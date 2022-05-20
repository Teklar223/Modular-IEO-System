using System.Threading;

// https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/exceptions/creating-and-throwing-exceptions

namespace encryption_exercise
{
    public class ProcessRunner
    {
        public void executeStrategy(AbstractProcess strategy)
        {
            if (!strategy.supportsAsync())
            {
                strategy.Process();
            }
            else
            {
                throw new InvalidOperationException("Do dont run async functions using a synced method.");
            }
        }
        public void executeAsyncStrategy(AbstractProcess strategy)
        {
            if (strategy.supportsAsync())
            {
            Thread t = new Thread(new ThreadStart(strategy.Process));
            t.Start();
            }
            else
            {
                throw new InvalidOperationException("Do dont run synced functions using an async method.");
            }
        }
    }
}