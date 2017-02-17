using SuperSocket.SocketBase.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperSocket.SocketBase;

namespace MobileControlSystem.Core.Socket
{
    /// <summary>
    /// 命令过滤器
    /// </summary>
    public class CustomCommandFilter : CommandFilterAttribute
    {
        public override void OnCommandExecuted(CommandExecutingContext commandContext)
        {

        }

        public override void OnCommandExecuting(CommandExecutingContext commandContext)
        {

        }
    }
}
