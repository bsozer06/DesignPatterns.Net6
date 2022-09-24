Abstraction ab = new RefinedAbstraction();

// Set implementation and call
ab.Implementor = new ConcreteImplementorA();
ab.Operation();

// Change implemention and call
ab.Implementor = new ConcreteImplementorB();
ab.Operation();

// Wait for user
Console.ReadKey();