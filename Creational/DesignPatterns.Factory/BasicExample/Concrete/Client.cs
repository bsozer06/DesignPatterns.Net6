using DesignPatterns.Factory.BasicExample.Abstract;

namespace DesignPatterns.Factory.BasicExample.Concrete
{
    public class Client
    {
        public void Main()
        {
            Creator creator1 = new ConcreteCreator1();
            Creator creator2 = new ConcreteCreator2();

            Console.WriteLine("App: Launched with the ConcreteCreator1.");
            ClientCode(creator1);

            Console.WriteLine("");

            Console.WriteLine("App: Launched with the ConcreteCreator2.");
            ClientCode(creator2);
        }

        // The client code works with an instance of a concrete creator, albeit
        // through its base interface. As long as the client keeps working with
        // the creator via the base interface, you can pass it any creator's
        // subclass.
        public void ClientCode(Creator creator)
        {
            // ...
            Console.WriteLine("Client: I'm not aware of the creator's class," +
                "but it still works.\n" + creator.SomeOperation());
            // ...
        }
    }
}
