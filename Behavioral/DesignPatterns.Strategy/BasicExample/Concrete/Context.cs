using DesignPatterns.Strategy.BasicExample.Abstract;

namespace DesignPatterns.Strategy.BasicExample.Concrete
{
    public class Context
    {
        private IStrategy _strategy;

        public Context() { }

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // Usually, the Context allows replacing a Strategy object at runtime.
        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        // The Context delegates some work to the Strategy object instead of
        // implementing multiple versions of the algorithm on its own.
        public void DoSomeBusinessLogic()
        {
            var result = this._strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

            string resultStr = string.Empty;
            foreach (var element in result as List<string>)
            {
                resultStr += element + ",";
            }

            Console.WriteLine(resultStr);
        }
    }
}
