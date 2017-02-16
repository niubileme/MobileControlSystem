using Nancy.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileControlSystem.HostServer
{
    public class FormsUser : IUserIdentity
    {
        public string UserName { get; set; }

        public IEnumerable<string> Claims { get; set; }
    }
}
