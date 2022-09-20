namespace DesignPatterns.Decorator
{
    public class LogginRepositoryDecorator<T> : DecoratorRepository<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public LogginRepositoryDecorator(IRepository<T> repository): base(repository)
        {
            _repository = repository;
        }

        public override void Add(T model)
        {
            base.Add(model);            // came from decorator

            Console.WriteLine($"LOG : {typeof(T).Name} was added.");
        }
        public override void Delete(T model)
        {
            base.Delete(model);         // came from decorator

            Console.WriteLine($"LOG : {typeof(T).Name} was deleted.");
        }
        public override void Update(T model)
        {
            base.Update(model);         // came from decorator

            Console.WriteLine($"LOG : {typeof(T).Name} was updated.");
        }
    }
}
