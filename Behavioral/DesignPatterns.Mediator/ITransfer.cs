using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Mediator
{
    /// <summary>
    /// IMediator Interface
    /// </summary>
    public interface ITransfer
    {
        void SendMoney(User user, int price);
    }
}
