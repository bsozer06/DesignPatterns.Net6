namespace DesignPatterns.Singleton
{
    public class LazyInitialization
    {
        /// Instance 'a erişilmemesi için
        private static LazyInitialization instance;

        /// new 'lenmemesi için private yapıldı.
        private LazyInitialization()
        {
        }

        public static LazyInitialization getInstance()
        {
            if (instance == null)
                instance = new LazyInitialization();

            return instance;
        }


    }

}
