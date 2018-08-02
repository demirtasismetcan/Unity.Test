using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Test.uLog;

namespace Unity.Test.uApp
{
    public class Application
    {
        private ILog _log = null;

        public Application(ILog _log)
        {
            this._log = _log;
        }

        public void Write()
        {
            Console.WriteLine("{0} {1}", _log.GetType().Name, _log.Info());
        }
    }
}
