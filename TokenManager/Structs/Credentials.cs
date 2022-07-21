using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenManager.Structs
{
    public class Credentials
    {
        public string User;
        public string Pass;
        public Credentials(string user, string pass)
        {
            User = user;
            Pass = pass;
        }
    }
}
