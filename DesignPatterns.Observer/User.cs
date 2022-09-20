namespace DesignPatterns.Observer
{
    public class User : IAbone
    {
        public void getMessage(string messsage)
        {
            Console.WriteLine(messsage);
        }
    }
}