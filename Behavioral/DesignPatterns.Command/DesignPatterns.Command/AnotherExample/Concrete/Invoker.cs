using DesignPatterns.Command.AnotherExample.Abstract;

namespace DesignPatterns.Command.AnotherExample.Concrete
{
    public class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
