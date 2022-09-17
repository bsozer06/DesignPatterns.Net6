namespace DesignPatterns.Adapter
{
    public class CryptClassCAdapter : ICrypt
    {
        private CryptClassC _cryptClassC;

        public CryptClassCAdapter(CryptClassC cryptClassC)
        {
            _cryptClassC = cryptClassC;
        }

        #region Come from interface
        public void Decrypt(string text)
        {
            Console.WriteLine("CryptClassC - Decrypt");
        }

        public void Encrypt(string text)
        {
            Console.WriteLine("CryptClassC - Encrypt");
        }
        #endregion

        #region Come from DI
        public void ToXmlByAdapter(string text)
        {
            _cryptClassC.ToXML("");
        }

        public void ToJsonByAdapter(string text)
        {
            _cryptClassC.ToJSON("");
        }

        #endregion

    }
}
