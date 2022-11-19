using DesignPatterns.Command.AnotherExample.Abstract;

namespace DesignPatterns.Command.AnotherExample.Concrete
{
    public class UpdateOrderCommand : ICommand
    {
        private Recievers _recievers;

        public UpdateOrderCommand(Recievers recievers)
        {
            _recievers = recievers;
        }

        public void Execute()
        {
            _recievers.UpdateOrderAction();
        }
    }
}
