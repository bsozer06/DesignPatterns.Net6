namespace DesignPatterns.Iterator
{
    /// <summary>
    /// ConcreteAggregate class
    /// </summary>
    public class EmployeeAggregate : IAggregate
    {
        List<Employee> EmployeeList = new List<Employee>();

        public int Count { get => EmployeeList.Count; }


        public void Add(Employee Model)
        {
            EmployeeList.Add(Model);
        }
        public Employee GetItem(int index)
        {
            return EmployeeList[index];
        }

        public IIterator CreateIterator()
        {
            return new EmployeeIterator(this);
        }
    }
}
