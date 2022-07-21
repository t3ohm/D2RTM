using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TokenManager.Interfaces
{
    public interface IKeyBind
    {
        string ascii { get; set; }
        string key { get; set; }
        bool enabled { get; set; }
    }
}
