namespace DesignPatterns.Observer.BasicExample.Abstract
{
    public interface IObserver
    {
        // Receive update from subject
        void Update(ISubject subject);
    }
}
