namespace DesignPatterns.Command.BasicExample.Concrete
{
    public class ConcreteCommandA : Command
    {
        public ConcreteCommandA(Reciever receiver) : base(receiver)
        {
        }

        public override void Execute()
        {
            _receiver.Action();
        }

    }
}
