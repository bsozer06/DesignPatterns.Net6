namespace DesignPatterns.Proxy
{
    /// <summary>
    /// Proxy class
    /// Here is  Protection Proxy Design
    /// </summary>
    public class BankProxy : IBank
    {
        Bank bank;
        bool isLogin;
        string UserName, Password;

        public BankProxy(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

        public bool LoginAccount()
        {
            if (UserName.Equals("burhan") && Password.Equals("123456789"))
            {
                bank = new Bank();          /// subject instance

                isLogin = true;
                Console.WriteLine("Login is done successfully.");
                return true;
            }
            else
                Console.WriteLine("You should become more careful to enter your username or password!");

            isLogin = false;
            return false;
        }

        public bool MakePayment(double price)
        {
            LoginAccount();

            if (!isLogin)
            {
                Console.WriteLine("Payment cannot be carried out because of not entering the account");
                return false;
            }

            bank.MakePayment(price);
            return true;
        }
    }
}
