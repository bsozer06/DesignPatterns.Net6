using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    /// <summary>
    /// Colleague abstract class
    /// </summary>
    public abstract class User
    {
        protected ITransfer _transfer;

        protected User(ITransfer transfer)
        {
            _transfer = transfer;
        }
    }
}
