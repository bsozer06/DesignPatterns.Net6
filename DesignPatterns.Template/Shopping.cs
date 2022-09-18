namespace DesignPatterns.Template
{
    /// <summary>
    /// abstract class
    /// </summary>
    public abstract class Shopping
    {
        protected string ProductName;
        protected PaymentType paymentType;

        #region constant methods

        void Start() => Console.WriteLine("Shopping is starting");
        void Finish() => Console.WriteLine($"Shopping finished.{ProductName} - {paymentType}.");

        #endregion


        #region changeable methods

        abstract public void Product();
        abstract public void PaymentSpecies();

        #endregion



        public void TemplateMethod()
        {
            Start();
            Product();
            PaymentSpecies();
            Finish();
        }
    }



    public enum PaymentType
    {
        cash,           // nakit
        installment     // taksit
    }
}
