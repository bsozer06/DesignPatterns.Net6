using DesignPatterns.Proxy;

string userName = "", password = "";
double price = 0;
while (true)
{
    Console.WriteLine("UserName:");
    userName = Console.ReadLine();

    Console.WriteLine("Password:");
    password = Console.ReadLine();

    Console.WriteLine("Price:");
    price = Convert.ToInt32(Console.ReadLine());

    IBank bank = new BankProxy(userName, password);
    bank.MakePayment(price);

    Console.WriteLine("************");
}