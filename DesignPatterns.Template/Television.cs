namespace DesignPatterns.Template
{
    /// <summary>
    /// Concrete class
    /// </summary>
    public class Television : Shopping
    {
        public override void PaymentSpecies()
        {
            paymentType = PaymentType.cash;
        }

        public override void Product()
        {
            ProductName = nameof(Television);
        }
    }
}
