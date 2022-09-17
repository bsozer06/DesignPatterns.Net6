namespace DesignPatterns.Mediator
{
    /// <summary>
    /// Concrete Colleague
    /// </summary>
    public class Estate : User
    {
        public Estate(ITransfer transfer) : base(transfer)
        {
        }

        public void GetCommission(int price)
        {
            Console.WriteLine($"Real estate : {price} $ was get price as commission.");

        }
    }

}

