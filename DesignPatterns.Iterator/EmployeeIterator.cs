namespace DesignPatterns.Iterator
{
    public class EmployeeIterator : IIterator
    {
        private EmployeeAggregate _aggregate;
        int currentindex;

        public EmployeeIterator(EmployeeAggregate aggregate)
        {
            _aggregate = aggregate;
        }



        public Employee CurrentItem()
        {
            return _aggregate.GetItem(currentindex);
        }

        public bool HasItem()
        {
            if (currentindex < _aggregate.Count) return true;
            return false;
        }

        public Employee NextItem()
        {
            if (HasItem()) return _aggregate.GetItem(currentindex++);
            return new Employee();
        }
    }
}