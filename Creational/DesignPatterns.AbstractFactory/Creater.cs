namespace DesignPatterns.AbstractFactory
{
    public class Creater
    {
        private IDatabaseFactory _databaseFactory;
        private ICommand _command;
        private IConnection _connection;

        public Creater(IDatabaseFactory databaseFactory)
        {
            _databaseFactory = databaseFactory;
            _command = _databaseFactory.CreateCommand();
            _connection = _databaseFactory.CreateConnection();

            Start();
        }

        private void Start()
        {
            if (_connection.State == "Open")
            {
                _connection.Connect();
                _command.Execute("Select * from...");
                _connection.DisConnect();
            }
        }
    }
}
