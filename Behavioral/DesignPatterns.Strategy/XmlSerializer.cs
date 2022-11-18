namespace DesignPatterns.Strategy
{
    /// <summary>
    /// Concrete type 1
    /// </summary>
    public class XmlSerializer : ISerializeable
    {
        public void Deserialize(string str)
        {
            Console.WriteLine("xml deserialized");
        }

        public void Serialize(string str)
        {
            Console.WriteLine("xml serialized");
        }
    }
}
