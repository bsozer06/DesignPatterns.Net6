using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory.BasicExample.Abstract
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod();

        public string SomeOperation()
        {
            // Call the factory method to create a Product object.
            var product = FactoryMethod();
            
            var result = "Creator: The same creator's code has just worked with " + product.Operation();

            return result;
        }
    }
}
