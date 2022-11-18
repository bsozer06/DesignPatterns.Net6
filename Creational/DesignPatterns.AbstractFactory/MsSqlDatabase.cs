namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// Concrete factory
    /// </summary>
    public class MsSqlDatabase : IDatabaseFactory
    {
        public ICommand CreateCommand()
        {
            return new MsSqlCommand();
        }

        public IConnection CreateConnection()
        {
            return new MsSqlConnection();
        }
    }
}
