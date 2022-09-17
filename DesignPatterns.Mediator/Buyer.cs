namespace DesignPatterns.Mediator
{
    public class Buyer : User
    {
        public Buyer(ITransfer transfer) : base(transfer)
        {
        }

        public void PayRent(int price)
        {
            Console.WriteLine("Buyer : Price was spent.");
            _transfer.SendMoney(this, price);
        }
    }
}
