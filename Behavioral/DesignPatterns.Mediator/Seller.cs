namespace DesignPatterns.Mediator
{
    /// <summary>
    /// Concrete Colleague
    /// </summary>
    public class Seller : User
    {
        public Seller(ITransfer transfer) : base(transfer)
        {
        }

        public void GetPrice(int price)
        {
            Console.WriteLine($"Seller : {price} $ was get money as building price.");
            _transfer.SendMoney(this, price);
        }
    }
}
