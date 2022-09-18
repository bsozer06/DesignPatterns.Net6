namespace DesignPatterns.Template
{
    /// <summary>
    /// Concrete class
    /// </summary>
    public class Fridge : Shopping
    {
        public override void PaymentSpecies()
        {
            paymentType = PaymentType.installment;
        }

        public override void Product()
        {
            ProductName = nameof(Fridge);
        }
    }
}
