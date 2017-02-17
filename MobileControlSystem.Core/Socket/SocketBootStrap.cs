using MobileControlSystem.Core.Config;
using MobileControlSystem.Core.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlSystem.Core.Socket
{
    public class SocketBootStrap
    {
        public static MyAppServer appServer;

        public static void Start()
        {
            appServer = new MyAppServer();
            var port = Convert.ToInt32(AppSettingConfig.Get("SocketPort"));
            if (!appServer.Setup(port))
            {
                Log.Error($"绑定端口失败：{port}", "socket");
            }
            Console.WriteLine();
            if (!appServer.Start())
            {
                Log.Error($"启动失败：{port}", "socket");
            }
        }

        public static void Close()
        {
            appServer.Stop();
        }
    }
}
