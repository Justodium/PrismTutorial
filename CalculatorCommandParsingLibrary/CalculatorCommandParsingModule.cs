using InterfacesLibrary;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommandParsingLibrary
{
  public class CalculatorCommandParsingModule : IModule
  {
    private readonly IUnityContainer container;

    public CalculatorCommandParsingModule(IUnityContainer container)
    {
      this.container = container;
    }

    public void Initialize()
    {
      this.container.RegisterType<IInputParserService, InputParserService>();
    }
  }
}
