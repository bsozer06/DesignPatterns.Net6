namespace DesignPatterns.Factory
{
    public class FactoryClass
    {
        public IGame CreatorInstance(GameType gameType)
        {
            IGame game = null;

            switch (gameType)
            {
                case GameType.Computer:
                    game = new Computer();
                    break;
                case GameType.Playstation:
                    game = new Playstation();
                    break;
                default:
                    break;
            }

            return game;
        }
    }

    public enum GameType
    {
        Computer,
        Playstation
    }
}
