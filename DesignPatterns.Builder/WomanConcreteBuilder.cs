namespace DesignPatterns.Builder
{
    public class WomanConcreteBuilder : PromotionBuilder
    {
        public WomanConcreteBuilder()
        {
            promotion = new Promotion();
        }

        public override void SetEmployeeProfile()
        {
            promotion.EmployeeProfile = "Woman";
        }

        public override void SetProductName()
        {
            promotion.ProductName = "Bag";
        }

        public override void SetPromotionNumber()
        {
            promotion.PromotionNumber = 999;
        }
    }
}
