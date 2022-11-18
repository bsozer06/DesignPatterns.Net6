namespace DesignPatterns.State
{
    /// <summary>
    /// state abstract class
    /// </summary>
    public abstract class MusicPlayerState
    {
        public abstract void PlayMusic();
        public abstract void StopMusic();
    }
}
