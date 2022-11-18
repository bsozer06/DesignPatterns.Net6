namespace DesignPatterns.Decorator
{
    public interface IRepository<T> where T : class
    {
        T Get(int id);

        T GetAll();

        void Add(T model);

        void Delete(T model);

        void Update(T model);
        
    }
}
