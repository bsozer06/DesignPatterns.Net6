namespace DesignPatterns.State
{
    /// <summary>
    /// Concrete state
    /// </summary>
    public class Play : MusicPlayerState
    {
        private MusicPlayerContext _context;

        public Play(MusicPlayerContext context)
        {
            _context = context;
        }

        public override void PlayMusic()
        {
            Console.WriteLine("music are already playing!");
        }

        public override void StopMusic()
        {
            Console.WriteLine("music was stopped.");
            _context.SetStop();
        }
    }
}