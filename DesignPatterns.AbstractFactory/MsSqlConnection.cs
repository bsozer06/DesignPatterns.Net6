namespace DesignPatterns.AbstractFactory
{
    /// <summary>
    /// Concrete product
    /// </summary>
    public class MsSqlConnection : IConnection
    {
        public string State => "Open";

        public bool Connect()
        {
            Console.WriteLine("SqlConnection is starting.");
            return true;
        }

        public bool DisConnect()
        {
            Console.WriteLine("SqlConnection is disposing.");
            return false;
        }
    }
}
