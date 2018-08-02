using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity.Injection;
using Unity.Test.uApp;
using Unity.Test.uLog;

namespace Unity.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<ILog, Log>();
            container.RegisterType<ILog, ConsoleLog>("ConsoleLog");

            container.RegisterType<Application>("appConsoleLog",
                new InjectionConstructor(container.Resolve<ILog>("ConsoleLog")));

            Application app1 = container.Resolve<Application>();
            app1.Write();

            Application app2 = container.Resolve<Application>("appConsoleLog");
            app2.Write();

            Console.ReadLine();
        }
    }
}
