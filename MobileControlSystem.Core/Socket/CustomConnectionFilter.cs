using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace MobileControlSystem.Core.Socket
{
    public class CustomConnectionFilter : IConnectionFilter
    {
        public string Name
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool AllowConnect(IPEndPoint remoteAddress)
        {
            throw new NotImplementedException();
        }

        public bool Initialize(string name, IAppServer appServer)
        {
            throw new NotImplementedException();
        }
    }
}
