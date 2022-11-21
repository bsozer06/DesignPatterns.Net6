//using DesignPatterns.Observer;
using DesignPatterns.Observer.BasicExample.Concrete;

Subject subject = new();
ConcreteObserverA observerA = new();
ConcreteObserverB observerB = new();

subject.Attach(observerA);
subject.Attach(observerB);

subject.SomeBusinessLogic();
subject.SomeBusinessLogic();

subject.Detach(observerB);

subject.SomeBusinessLogic();

//var banker = new BankerObserver();
//var customer = new CustomerObserver();
//var officer = new OfficerObserver();

//var notificaiton = new Notification();

//notificaiton.addUser(banker);
//notificaiton.addUser(customer);
//notificaiton.addUser(officer);

//notificaiton.sendMessage("Notification: Price was spent.");

//notificaiton.removeUser(banker);
//notificaiton.sendMessage("Notification: Contrant will be signed.");