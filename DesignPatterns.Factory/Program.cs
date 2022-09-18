using DesignPatterns.Factory;

var factoryClass = new FactoryClass();

var playstationInstance = factoryClass.CreatorInstance(GameType.Playstation);
var computerInstance = factoryClass.CreatorInstance(GameType.Computer);

playstationInstance.Platform();
computerInstance.Platform();

Console.Read();

