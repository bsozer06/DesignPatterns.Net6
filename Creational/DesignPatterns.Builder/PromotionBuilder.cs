namespace DesignPatterns.Builder
{
    /// <summary>
    /// builder class
    /// </summary>
    public abstract class PromotionBuilder
    {
        protected Promotion promotion;
        public Promotion Promotion
        {
            get
            {
                return promotion;
            }
        }
        public abstract void SetProductName();
        public abstract void SetPromotionNumber();
        public abstract void SetEmployeeProfile();
    }
}
