using MobileControlSystem.Core.Logger;
using SuperSocket.SocketBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlSystem.Core.Socket
{
    public class MyAppServer : AppServer<MyAppSession>
    {
        protected override void OnStarted()
        {
            base.OnStarted();
            Log.Success($"Start", "socket");
        }

        protected override void OnStopped()
        {
            base.OnStopped();
            Log.Info($"Stop", "socket");
        }

        protected override void OnNewSessionConnected(MyAppSession session)
        {
            base.OnNewSessionConnected(session);
        }

        protected override void OnSessionClosed(MyAppSession session, CloseReason reason)
        {
            base.OnSessionClosed(session, reason);
        }

    }
}
