using DesignPatterns.AbstractFactory;

var creater = new Creater(new MsSqlDatabase());

Console.WriteLine("----------------------------");

creater = new Creater(new MySqlDatabase());

Console.Read();