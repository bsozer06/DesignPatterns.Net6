using DesignPatterns.State.BasicExample.Concrete;

namespace DesignPatterns.State.BasicExample
{
    public abstract class State
    {
        public abstract void Handle(Context context);
    }
}
