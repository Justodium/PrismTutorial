using CommonTypesLibrary;
using InterfacesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCommandParsingLibrary
{
  public class InputParserService : IInputParserService
  {
    public CommandTypes ParseCommand(string command)
    {
      return (CommandTypes)Enum.Parse(typeof(CommandTypes), command);
    }
  }
}
