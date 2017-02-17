using SuperSocket.SocketBase.Command;
using SuperSocket.SocketBase.Protocol;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlSystem.Core.Socket
{
    public class MyCommand : CommandBase<MyAppSession, StringRequestInfo>
    {
        public override void ExecuteCommand(MyAppSession session, StringRequestInfo requestInfo)
        {
            session.Send(requestInfo.Body);
        }
    }
}
