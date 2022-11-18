namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// Concrete factory
    /// </summary>
    public class MySqlDatabase : IDatabaseFactory
    {
        public ICommand CreateCommand()
        {
            return new MySqlCommand();
        }

        public IConnection CreateConnection()
        {
            return new MySqlConnection();
        }
    }
}
