namespace DesignPatterns.Iterator
{
    public interface IAggregate
    {
        IIterator CreateIterator();
    }
}
