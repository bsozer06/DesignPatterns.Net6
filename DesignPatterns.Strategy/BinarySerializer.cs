namespace DesignPatterns.Strategy
{
    /// <summary>
    /// concrete type 2
    /// </summary>
    public class BinarySerializer : ISerializeable
    {
        public void Deserialize(string str)
        {
            Console.WriteLine("binary deserialized");
        }

        public void Serialize(string str)
        {
            Console.WriteLine("binary serialized");
        }
    }
}
