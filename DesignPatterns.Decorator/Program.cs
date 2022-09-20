using DesignPatterns.Decorator;

Console.WriteLine("Repository");
Repository<Product> repository = new Repository<Product>();
repository.Get(3);
repository.GetAll();
repository.Add(new Product());
repository.Delete(new Product());
repository.Update(new Product());

Console.WriteLine("-------------------------------------------");

Console.WriteLine("\nSecurityRepositoryDecorator");
SecurityRepositoryDecorator<Product> securityRepositoryDecorator = new SecurityRepositoryDecorator<Product>(repository);
securityRepositoryDecorator.Get(3);
securityRepositoryDecorator.GetAll();
securityRepositoryDecorator.Add(new Product());
securityRepositoryDecorator.Delete(new Product());
securityRepositoryDecorator.Update(new Product());


