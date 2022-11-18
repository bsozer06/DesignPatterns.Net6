using DesignPatterns.Facade;

var facede = new FacadeClass();

facede.UtilizeCreditCard(new Customer
{
    CustomerNumber = 123456789,
    IdentityNumber = "888888888",
    Name = "Burhan"
}, 
100000);