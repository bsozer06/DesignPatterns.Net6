using DesignPatterns.Builder;

var director = new PromotionDirector();

PromotionBuilder promotion = new BossConcreteBuilder();
director.Send(promotion);
promotion.Promotion.ToString();

promotion = new LaborConcreteBuilder();
director.Send(promotion);
promotion.Promotion.ToString();

