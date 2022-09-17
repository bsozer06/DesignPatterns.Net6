namespace DesignPatterns.Adapter
{
    public class CryptClassB : ICrypt
    {
        public void Decrypt(string text)
        {
            Console.WriteLine("CryptClassB - Decrypt");
        }

        public void Encrypt(string text)
        {
            Console.WriteLine("CryptClassB - Encrypt");
        }
    }
}
