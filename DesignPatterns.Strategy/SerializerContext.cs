namespace DesignPatterns.Strategy
{
    /// <summary>
    /// Context type
    /// </summary>
    public class SerializerContext
    {
        private ISerializeable _serializeable;

        public SerializerContext(ISerializeable serializeable)
        {
            _serializeable = serializeable;
        }

        public void SerializeByContext(string str)
        {
            _serializeable.Serialize(str);
        }

        public void DeserializeByContext(string str)
        {
            _serializeable.Deserialize(str);
        }
    }
}
