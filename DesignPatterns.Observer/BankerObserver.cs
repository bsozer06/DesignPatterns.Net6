namespace DesignPatterns.Observer
{
    public class BankerObserver : IAbone
    {
        public void getMessage(string messsage)
        {
            Console.WriteLine($"Banker: " + messsage);
        }
    }
}
