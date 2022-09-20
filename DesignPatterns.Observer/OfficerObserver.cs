namespace DesignPatterns.Observer
{
    public class OfficerObserver : IAbone
    {
        public void getMessage(string messsage)
        {
            Console.WriteLine($"Officer: " + messsage);
        }
    }
}
