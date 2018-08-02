using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unity.Test.uLog
{
    public class Log : ILog
    {
        public string Info()
        {
            return " injected.";
        }
    }
}
