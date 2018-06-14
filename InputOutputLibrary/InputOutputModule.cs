using InterfacesLibrary;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputLibrary
{
  public class InputOutputModule : IModule
  {
    private readonly IUnityContainer container;

    public InputOutputModule(IUnityContainer container)
    {
      this.container = container;
    }

    public void Initialize()
    {
      this.container.RegisterType<IInputService, ConsoleInputService>()
                    .RegisterType<IOutputService, ConsoleOutputService>("OutputService1")
                    .RegisterType<IOutputService, MsgBoxOutputService>("OutputService2");

    }
  }
}
