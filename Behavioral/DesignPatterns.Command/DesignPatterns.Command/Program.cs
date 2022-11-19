using DesignPatterns.Command.AnotherExample.Abstract;
using DesignPatterns.Command.AnotherExample.Concrete;

Recievers reciever = new();
ICommand addOrderCommand = new AddOrderCommand(reciever);
ICommand updateOrderCommand = new UpdateOrderCommand(reciever);

Invoker invoker = new();

invoker.SetCommand(addOrderCommand);
invoker.ExecuteCommand();

invoker.SetCommand(updateOrderCommand);
invoker.ExecuteCommand();


Console.ReadKey();
