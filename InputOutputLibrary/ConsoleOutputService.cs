﻿using InterfacesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputLibrary
{
  public class ConsoleOutputService : IOutputService
  {
    public void WriteMessage(string message)
    {
      Console.WriteLine(message);
    }
  }
}
