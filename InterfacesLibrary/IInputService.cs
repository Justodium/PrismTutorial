using CommonTypesLibrary;

namespace InterfacesLibrary
{
  public interface IInputService
  {
    Arguments ReadArguments();
    string ReadCommand();
  }
}