using DesignPatterns.Strategy;

var xmlSerializer = new SerializerContext(new XmlSerializer());
var binarySerializer = new SerializerContext(new BinarySerializer());

xmlSerializer.SerializeByContext("xml serializer from the context");
xmlSerializer.DeserializeByContext("xml deserializer from the context");

binarySerializer.SerializeByContext("binary deserializer from the context");
binarySerializer.DeserializeByContext("binary deserializer from the context");

