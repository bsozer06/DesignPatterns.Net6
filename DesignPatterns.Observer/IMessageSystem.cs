namespace DesignPatterns.Observer
{
    /// <summary>
    /// Observable: değişimden etkilenecek olan 
    /// </summary>
    public interface IMessageSystem
    {
        void addUser(IAbone user);
        void removeUser(IAbone user);
        void sendMessage(string message);
    }
}
