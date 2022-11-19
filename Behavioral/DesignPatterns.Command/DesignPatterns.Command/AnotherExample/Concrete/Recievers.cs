namespace DesignPatterns.Command.AnotherExample.Concrete
{
    public class Recievers
    {
        public void AddOrderAction() => Console.WriteLine("Added order!");
        public void UpdateOrderAction() => Console.WriteLine("Updated order!");
    }
}
