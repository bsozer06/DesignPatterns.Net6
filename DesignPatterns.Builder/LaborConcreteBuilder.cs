namespace DesignPatterns.Builder
{
    public class LaborConcreteBuilder : PromotionBuilder
    {
        public LaborConcreteBuilder()
        {
            promotion = new Promotion();
        }

        public override void SetEmployeeProfile()
        {
            promotion.EmployeeProfile = "Labor";
        }

        public override void SetProductName()
        {
            promotion.ProductName = "Jacket";
        }

        public override void SetPromotionNumber()
        {
            promotion.PromotionNumber = 666;
        }
    }
}
