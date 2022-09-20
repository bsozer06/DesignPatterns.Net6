using DesignPatterns.Observer;

var banker = new User();
var customer = new User();
var officer = new User();

var notificaiton = new Notification();

notificaiton.addUser(banker);
notificaiton.addUser(customer);
notificaiton.addUser(officer);

notificaiton.sendMessage("this is notification.");