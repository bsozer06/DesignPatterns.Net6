namespace DesignPatterns.Singleton
{
    public class EagerInitialization
    {
        /// Instance 'a erişilmemesi için
        private static EagerInitialization instance = new EagerInitialization();

        /// new 'lenmemesi için private yapıldı.
        private EagerInitialization()
        {
        }

        public static EagerInitialization getInstance()
        {
            return instance;
        }


    }
}
