namespace DesignPatterns.Builder
{
    /// <summary>
    /// Director class
    /// </summary>
    public class PromotionDirector
    {
        public void Send(PromotionBuilder builder)
        {
            builder.SetPromotionNumber();
            builder.SetEmployeeProfile();
            builder.SetProductName();
        }
    }
}
