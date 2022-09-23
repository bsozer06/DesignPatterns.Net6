namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// Abstract product
    /// </summary>
    public interface ICommand
    {
        void Execute(string query);
    }
}
