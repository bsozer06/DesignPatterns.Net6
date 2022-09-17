namespace DesignPatterns.Adapter
{
    public interface ICrypt
    {
        void Encrypt(String text);
        void Decrypt(String text);
    }
}
