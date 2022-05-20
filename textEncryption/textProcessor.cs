using System.Threading;

namespace encryption_exercise
{
    public class TextProcessor
    {
        private aStrategy strategy;

        public TextProcessor(){
            strategy = new ProcessingStrategy(); //a default strategy.
        }

        public TextProcessor(aStrategy strat){
            strategy = strat;
        }

        public aStrategy getStrategy()
        {
            return strategy;
        }

        public void setStrategy(aStrategy newStrategy)
        {
            this.strategy = newStrategy;
        }

        public void executeStrategy()
        {
            Thread t = new Thread(new ThreadStart(this.strategy.Process));
            t.Start();
        }
    }
}