using DesignPatterns.State;
using DesignPatterns.State.BasicExample;
using DesignPatterns.State.BasicExample.Concrete;

//  Basic Example

State concreteStateA = new ConcreteStateB();

Context context = new(concreteStateA);

context.Request();
context.Request();
context.Request();



//var context = new MusicPlayerContext();

//context.Play();
//context.Stop();
//Console.WriteLine("---------------------");
//context.Stop();
//context.Play();
//Console.WriteLine("---------------------");
//context.Stop();
//Console.WriteLine("---------------------");
//context.Play();
//context.Stop();

