using DesignPatterns.Iterator;

var aggregate = new EmployeeAggregate();
aggregate.Add(new Employee { Id = 1, Name = "Burhan1", Surname = "Sözer1" });
aggregate.Add(new Employee { Id = 2, Name = "Burhan2", Surname = "Sözer2" });
aggregate.Add(new Employee { Id = 3, Name = "Burhan3", Surname = "Sözer3" });
aggregate.Add(new Employee { Id = 4, Name = "Burhan4", Surname = "Sözer4" });
aggregate.Add(new Employee { Id = 5, Name = "Burhan5", Surname = "Sözer5" });

IIterator iterasyon = aggregate.CreateIterator();
while (iterasyon.HasItem())
{
    Console.WriteLine($"ID : {iterasyon.CurrentItem().Id}\nAdı : {iterasyon.CurrentItem().Name}\nSurname: {iterasyon.CurrentItem().Surname}\n-----------------");
    iterasyon.NextItem();
}

Console.Read();