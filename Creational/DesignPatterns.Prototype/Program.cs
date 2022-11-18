using DesignPatterns.Prototype;

Game game = new Game(1, "Mario", "Adventure", true);

Game clonedGame = (Game)game.Clone();

if (game.Equals(clonedGame))
    Console.WriteLine("Equal");
else
    Console.WriteLine("Not equal");

Console.Read();