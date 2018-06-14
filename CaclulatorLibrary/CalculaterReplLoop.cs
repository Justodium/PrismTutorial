using CommonTypesLibrary;
using InterfacesLibrary;
using Microsoft.Practices.ServiceLocation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
  public class CalculaterReplLoop : ICalculaterReplLoop
  {
    private readonly ICalculator calculator;
    private readonly IInputService inputService;
    private readonly List<IOutputService> outputServices;
    private readonly IInputParserService inputParserService;

    public CalculaterReplLoop(
      IServiceLocator locator,
      ICalculator calculator, 
      IInputService inputService, 
      IInputParserService inputParserService)
    {
      this.calculator = calculator;
      this.inputService = inputService;
      this.inputParserService = inputParserService;
      this.outputServices = new List<IOutputService>(
        locator.GetAllInstances<IOutputService>());
    }

    public void Run()
    {
      while (true)
      {
        string command = this.inputService.ReadCommand();

        try
        {
          CommandTypes commandType = this.inputParserService.ParseCommand(command);

          Arguments args = this.inputService.ReadArguments();

          this.WriteMessageToAllOutputServices(this.calculator.Execute(commandType, args).ToString());
        }
        catch (Exception)
        {
          this.WriteMessageToAllOutputServices("Mistake!");
        }
      }
    }

    private void WriteMessageToAllOutputServices(string message)
    {
      foreach (var service in this.outputServices)
      {
        service.WriteMessage(message);
      }
    }
  }
}
