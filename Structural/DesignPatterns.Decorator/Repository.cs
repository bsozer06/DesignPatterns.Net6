namespace DesignPatterns.Decorator
{
    // We did not change repository class
    public class Repository<T> : IRepository<T> where T : class
    {
        public T Get(int id)
        {
            Console.WriteLine("Get model by Id.");
            return null;
        }
        public T GetAll()
        {
            Console.WriteLine("Get all.");
            return null;
        }
        public void Add(T model)
        {
            Console.WriteLine("Added model.");
        }
        public void Delete(T model)
        {
            Console.WriteLine("Removed model.");
        }
        public void Update(T model)
        {
            Console.WriteLine("Updated model.");
        }
    }
}
