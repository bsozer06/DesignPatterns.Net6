namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// Abstract product
    /// </summary>
    public interface IConnection
    {
        bool Connect();
        bool DisConnect();
        string State { get; }
    }
}
