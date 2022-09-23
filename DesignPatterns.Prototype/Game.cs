namespace DesignPatterns.Prototype
{
    public class Game: GamePrototype
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool State { get; set; }

        public Game(int id, string name, string type, bool state)
        {
            Id = id;
            Name = name;
            Type = type;
            State = state;
        }

        public override GamePrototype Clone()
        {
            return this.MemberwiseClone() as GamePrototype;
        }
    }
}
