namespace DesignPatterns.State
{
    /// <summary>
    /// Concrete state
    /// </summary>
    public class Stop : MusicPlayerState
    {
        private MusicPlayerContext _context;

        public Stop(MusicPlayerContext context)
        {
            _context = context;
        }

        public override void PlayMusic()
        {
            Console.WriteLine("Music was started.");
            _context.SetPlay();
        }

        public override void StopMusic()
        {
            Console.WriteLine("Music have been already stopped");
        }
    }
}