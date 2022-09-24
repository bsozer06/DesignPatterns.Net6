namespace DesignPatterns.Builder
{
    public class BossConcreteBuilder : PromotionBuilder
    {
        public BossConcreteBuilder()
        {
            promotion = new Promotion();
        }

        public override void SetEmployeeProfile()
        {
            promotion.EmployeeProfile = "Boss";
        }

        public override void SetProductName()
        {
            promotion.ProductName = "Job";
        }

        public override void SetPromotionNumber()
        {
            promotion.PromotionNumber = 333;
        }
    }
}
