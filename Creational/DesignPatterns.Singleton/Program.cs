using DesignPatterns.Singleton;

/* bu şekilde hatalar alınır. 
 
var instance1 = new LazyInitialization();
var instance2 = new EagerInitialization();,

 */

var lazyInstance = LazyInitialization.getInstance();
var eagerInstance = EagerInitialization.getInstance();

if (lazyInstance.Equals(eagerInstance))
    Console.WriteLine("lazyInstance = eagerInstance");
else
    Console.WriteLine("lazyInstance != eagerInstance");
