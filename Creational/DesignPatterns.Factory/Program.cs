using DesignPatterns.Factory;

FactoryClass factoryClass = new();

IGame playstationInstance = factoryClass.CreatorInstance(GameType.Playstation);
IGame computerInstance = factoryClass.CreatorInstance(GameType.Computer);

playstationInstance.Platform();
computerInstance.Platform();

Console.Read();



//using DesignPatterns.Factory.BasicExample.Concrete;

//new Client().Main();
