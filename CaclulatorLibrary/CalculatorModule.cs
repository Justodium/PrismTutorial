using InterfacesLibrary;
using Microsoft.Practices.Unity;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
  public class CalculatorModule : IModule
  {
    private readonly IUnityContainer container;

    public CalculatorModule(IUnityContainer container)
    {
      this.container = container;
    }

    public void Initialize()
    {
      this.container.RegisterType<ICalculator, Calculator>()
                    .RegisterType<ICalculaterReplLoop, CalculaterReplLoop>();
    }
  }
}
