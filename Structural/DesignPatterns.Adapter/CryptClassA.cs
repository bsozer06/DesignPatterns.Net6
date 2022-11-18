namespace DesignPatterns.Adapter
{
    public class CryptClassA : ICrypt
    {
        public void Decrypt(string text)
        {
            Console.WriteLine("CryptClassA - Decrypt");
        }

        public void Encrypt(string text)
        {
            Console.WriteLine("CryptClassA - Encrypt");
        }
    }
}
