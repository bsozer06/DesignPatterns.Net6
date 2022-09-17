using DesignPatterns.Mediator;

var transfer = new Transfer();

var buyer = new Buyer(transfer);
var estate = new Estate(transfer);
var seller = new Seller(transfer);

transfer.Buyer = buyer;
transfer.Estate = estate;
transfer.Seller = seller;

buyer.PayRent(5000);