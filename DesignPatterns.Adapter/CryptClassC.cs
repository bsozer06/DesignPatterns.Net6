namespace DesignPatterns.Adapter
{
    /// <summary>
    /// CryptClassC class did not be implemented by ICrypt
    /// </summary>
    public class CryptClassC
    {
        public void ToJSON(string text)
        {
            Console.WriteLine("CryptClassC - toJSON");
        }

        public void ToXML(string text)
        {

            Console.WriteLine("CryptClassC - toXML");
        }
    }
}
