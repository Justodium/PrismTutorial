using InterfacesLibrary;
using Microsoft.Practices.ServiceLocation;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainModuleLibrary
{
  public class MainModule : IModule
  {
    private readonly IServiceLocator serviceLocator;

    public MainModule(IServiceLocator serviceLocator)
    {
      this.serviceLocator = serviceLocator;
    }
    
    public void Initialize()
    {
      ICalculaterReplLoop loop = serviceLocator.GetInstance<ICalculaterReplLoop>();

      loop.Run();
    }
  }
}
