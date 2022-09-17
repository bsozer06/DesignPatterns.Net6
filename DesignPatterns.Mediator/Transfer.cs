namespace DesignPatterns.Mediator
{
    /// <summary>
    /// Concrete Mediator
    /// </summary>
    public class Transfer : ITransfer
    {
        Buyer buyer;
        Estate estate;
        Seller seller;

        public Buyer Buyer { set => buyer = value; }
        public Estate Estate { set => estate = value; }
        public Seller Seller { set => seller = value; }

        public void SendMoney(User user, int price)
        {
            if (user is Buyer && price > 100000)
                seller.GetPrice(price);
            else if (user is Buyer && price <= 100000)
            {
                estate.GetCommission(price * 10 / 100);
                seller.GetPrice(price);
            }
            else if (user is Seller && price > 100000)
                estate.GetCommission(price * 3 / 100);
        }
    }
}
