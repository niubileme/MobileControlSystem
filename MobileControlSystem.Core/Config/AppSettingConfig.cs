using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlSystem.Core.Config
{
    public class AppSettingConfig
    {
        public static string Get(string name)
        {
            return ConfigurationManager.AppSettings[name];
        }
    }
}
