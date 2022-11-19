namespace DesignPatterns.Command.BasicExample
{
    public abstract class Command
    {
        protected Reciever _receiver;

        public Command(Reciever receiver)
        {
            _receiver = receiver;
        }

        public abstract void Execute();

    }
}
