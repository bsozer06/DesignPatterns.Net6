namespace DesignPatterns.AbstractFactory
{
    public class MySqlConnection: IConnection
    {
        public string State => "Open";

        public bool Connect()
        {
            Console.WriteLine("MySqlConnection is starting.");
            return true;
        }

        public bool DisConnect()
        {
            Console.WriteLine("MySqlConnection is disposing.");
            return false;
        }
    }
}
