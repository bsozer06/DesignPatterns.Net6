namespace DesignPatterns.AbstractFactory
{
    public class MySqlCommand : ICommand
    {
        public void Execute(string query)
        {
            Console.WriteLine("MySqlCommand query is started.");
        }

    }
}
