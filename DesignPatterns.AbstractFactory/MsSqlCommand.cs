namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// Concrete product
    /// </summary>
    public class MsSqlCommand : ICommand
    {
        public void Execute(string query)
        {
            Console.WriteLine("SqlCommand query is started.");
        }

    }
}

