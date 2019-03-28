using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWcpApplication
{
    class MyService : IMyService
    {
        public string Hello(string name)
        {
            return $"Hello {name} from container!";
        }
    }
}
