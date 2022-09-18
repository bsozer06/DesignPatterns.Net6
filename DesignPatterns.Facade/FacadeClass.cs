namespace DesignPatterns.Facade
{
    public class FacadeClass
    {
        private Bank _bank;
        private Credit _credit;
        private CentralBank _centralBank;

        // DI is not applied not to depend our properties
        public FacadeClass()
        {
            _bank = new Bank();
            _credit = new Credit();
            _centralBank = new CentralBank();
        }

        public void UtilizeCreditCard(Customer customer, decimal quantity)
        {
            if (!_centralBank.IsCustomerInBlackList(customer.IdentityNumber) && _credit.UsageCreditState(customer)) { 
                _bank.UseCredit(customer, quantity);
                Console.WriteLine($"{quantity} credit was given {customer.Name} successfully");
            }
        }

    }
}
