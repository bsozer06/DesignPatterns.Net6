using DesignPatterns.Command.AnotherExample.Abstract;

namespace DesignPatterns.Command.AnotherExample.Concrete
{
    public class AddOrderCommand : ICommand
    {
        private Recievers _orderRecievers;

        public AddOrderCommand(Recievers orderRecievers)
        {
            _orderRecievers = orderRecievers;
        }

        public void Execute()
        {
            _orderRecievers.AddOrderAction();
        }
    }
}
