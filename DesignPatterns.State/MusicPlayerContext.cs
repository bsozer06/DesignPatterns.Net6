namespace DesignPatterns.State
{
    /// <summary>
    /// Context class
    /// </summary>
    public class MusicPlayerContext
    {
        MusicPlayerState state;
        MusicPlayerState play;
        MusicPlayerState stop;

        public MusicPlayerContext()
        {
            play = new Play(this);
            stop = new Stop(this);
            state = play;
        }

        public void SetPlay() => state = play;
        public void SetStop() => state = stop;


        public void Play() => state.PlayMusic();
        public void Stop() => state.StopMusic();


    }
}
