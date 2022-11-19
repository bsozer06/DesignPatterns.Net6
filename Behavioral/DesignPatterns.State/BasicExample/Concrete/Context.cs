

namespace DesignPatterns.State.BasicExample.Concrete
{
    public class Context
    {
        private State _state;

        public State State
        {
            get 
            {
                return _state; 
            }
            set 
            {
                _state = value;
                Console.WriteLine("State Changed: " + _state.GetType().Name);
            }
        }

        public Context(State state)
        {
            _state = state;
        }

        public void Request()
        {
            _state.Handle(this);
        }

        

    }
}
