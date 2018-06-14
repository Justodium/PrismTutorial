using InterfacesLibrary;
using Microsoft.Practices.Unity.Configuration;
using Prism.Logging;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Practices.ServiceLocation;
using Prism.Unity;
using Microsoft.Practices.Unity;

namespace Application
{
  class Program
  {
    static void Main(string[] args)
    {
      IUnityContainer container = new UnityContainer();
        //.LoadConfiguration();

      container.RegisterInstance<IServiceLocator>(new UnityServiceLocatorAdapter(container));

      TextLogger logger = new TextLogger();
      container.RegisterInstance<ILoggerFacade>(logger);
      container.RegisterType<IModuleInitializer, ModuleInitializer>();
      ConfigurationModuleCatalog catalog = new ConfigurationModuleCatalog();
      container.RegisterInstance<IModuleCatalog>(catalog);
      container.RegisterType<IModuleManager, ModuleManager>();

      IModuleManager manager = container.Resolve<IModuleManager>();
      manager.Run();

      //ICalculaterReplLoop calculaterReplLoop = container.Resolve<ICalculaterReplLoop>();
      //calculaterReplLoop.Run();
    }
  }
}
