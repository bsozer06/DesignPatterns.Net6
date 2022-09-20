namespace DesignPatterns.Observer
{
    /// <summary>
    /// Observable: değişimden etkilenecek olan 
    /// </summary>
    public interface IMessageSystem
    {
        void addUser(User user);
        void removeUser(User user);
        void sendMessage(string message);
    }
}
