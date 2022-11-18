namespace DesignPatterns.Decorator
{
    public class SecurityRepositoryDecorator<T> : DecoratorRepository<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public SecurityRepositoryDecorator(IRepository<T> repository) : base(repository)
        {
            _repository = repository;
        }

        public override T Get(int id)
        {
            Console.WriteLine("Checking security...");

            return base.Get(id);            // came from decorator
        }

        public override T GetAll()
        {
            Console.WriteLine("Checking security...");

            return base.GetAll();        // came from decorator
        }   

    }
}
