namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// abstract factory
    /// </summary>
    public interface IDatabaseFactory
    {
        IConnection CreateConnection();
        ICommand CreateCommand();
    }
}
