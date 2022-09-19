namespace DesignPatterns.Proxy
{
    /// <summary>
    /// subject class
    /// </summary>
    public class Bank : IBank
    {
        public bool MakePayment(double price)
        {
            if (price < 100)
                Console.WriteLine($"Price you pay should not be less than 100$. Difference: { 100 - price }");
            else if (price > 100)
                Console.WriteLine($"Price you pay should not be more than 100$. Difference: { price - 100 }");
            else
            {
                Console.WriteLine($"payment has been carried out successfully. -> { price }");
                return true;
            }

            return false;
        }
    }
}
