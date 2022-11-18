namespace DesignPatterns.Observer
{
    public class CustomerObserver : IAbone
    {
        public void getMessage(string messsage)
        {
            Console.WriteLine($"Customer: " + messsage);
        }
    }
}
