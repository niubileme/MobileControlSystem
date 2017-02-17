using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlSystem.Core.Socket
{
    /// <summary>
    /// 代表一个和客户端的逻辑连接
    /// </summary>
    public class MyAppSession : AppSession<MyAppSession>
    {
        protected override void OnSessionStarted()
        {
            base.OnSessionStarted();
        }

        protected override void OnSessionClosed(CloseReason reason)
        {
            base.OnSessionClosed(reason);
        }

        
    }
}
