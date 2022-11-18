namespace DesignPatterns.Observer
{
    public class Notification : IMessageSystem
    {
        private readonly List<IAbone> _users;

        public Notification()
        {
            _users = new List<IAbone>();
        }



        public void addUser(IAbone user)
        {
            _users.Add(user);
        }

        public void removeUser(IAbone user)
        {
            _users.Remove(user);
        }

        public void sendMessage(string message)
        {
            foreach (var user in _users)
            {
                user?.getMessage(message);
            }
        }
    }
}
