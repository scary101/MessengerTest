using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7
{
    public class User
    {
        public string username { get; set; }
        public string IpAdd { get; set; }

        public User(string name, string Ip)
        {
            username = name;
            IpAdd = Ip;
        }
    }
}
