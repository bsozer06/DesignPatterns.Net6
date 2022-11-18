using DesignPatterns.Strategy;
using DesignPatterns.Strategy.BasicExample.Abstract;
using DesignPatterns.Strategy.BasicExample.Concrete;

//ISerializeable xmlSerializerObj = new XmlSerializer();
//ISerializeable binarySerializerObj = new BinarySerializer();

//SerializerContext xmlSerializer = new(xmlSerializerObj);
//SerializerContext binarySerializer = new(binarySerializerObj);

//xmlSerializer.SerializeByContext("xml serializer from the context");
//xmlSerializer.DeserializeByContext("xml deserializer from the context");

//binarySerializer.SerializeByContext("binary deserializer from the context");
//binarySerializer.DeserializeByContext("binary deserializer from the context");




/// Basic Example

Context context = new();
IStrategy ConcreteStrategyA = new ConcreteStrategyA();
IStrategy ConcreteStrategyB = new ConcreteStrategyB();

context.SetStrategy(ConcreteStrategyA);
context.DoSomeBusinessLogic();

Console.WriteLine();

context.SetStrategy(ConcreteStrategyB);
context.DoSomeBusinessLogic();