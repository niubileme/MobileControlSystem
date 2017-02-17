using MobileControlSystem.Core.Socket;
using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlSystem.HostServer
{
    class Program
    {
        static void Main(string[] args)
        {
            //启动中控系统站点
            var webmanager = ConfigurationManager.AppSettings["WebManager"];
            var Host = new NancyHost(new Uri(webmanager));

            Host.Start();
            Console.WriteLine("中控系统已启动..." + webmanager);


            //启动Socket
            SocketBootStrap.Start();

            Console.Read();
        }
    }
}
