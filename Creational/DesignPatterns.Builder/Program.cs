using DesignPatterns.Builder;
using DesignPatterns.Builder.BasicExample.Concrete;

//var director = new PromotionDirector();

//PromotionBuilder promotion = new BossConcreteBuilder();
//director.Send(promotion);
//promotion.Promotion.ToString();

//promotion = new LaborConcreteBuilder();
//director.Send(promotion);
//promotion.Promotion.ToString();



#region Basic Example

// The client code creates a builder object, passes it to the
// director and then initiates the construction process. The end
// result is retrieved from the builder object.
var director = new Director();
var builder = new ConcreteBuilder();
director.Builder = builder;

Console.WriteLine("Standard basic product:");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListProduct());

Console.WriteLine("Standard full featured product:");
director.BuildFullFeaturedProduct();
Console.WriteLine(builder.GetProduct().ListProduct());

// Remember, the Builder pattern can be used without a Director
// class.
Console.WriteLine("Custom product:");
builder.BuildPartA();
builder.BuildPartC();
Console.Write(builder.GetProduct().ListProduct());

#endregion