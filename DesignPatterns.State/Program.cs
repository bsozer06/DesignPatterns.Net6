using DesignPatterns.State;

var context = new MusicPlayerContext();

context.Play();
context.Stop();
Console.WriteLine("---------------------");
context.Stop();
context.Play();
Console.WriteLine("---------------------");
context.Stop();
Console.WriteLine("---------------------");
context.Play();
context.Stop();

