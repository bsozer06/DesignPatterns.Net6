namespace DesignPatterns.Strategy
{
    /// <summary>
    /// base interface
    /// </summary>
    public interface ISerializeable
    {
        void Serialize(string str);
        void Deserialize(string str);
    }
}
