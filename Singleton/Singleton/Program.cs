using static System.Console;
namespace Singleton
{
  class Program
  {
    static void Main(string[] args)
    {
      Singleton fromManager = Singleton.SingleInstance;
      fromManager.LogMessage("Request Message from Manager");

      Singleton fromEmployee = Singleton.SingleInstance;
      fromEmployee.LogMessage("Request Message from Employee");

      ReadLine();
    }
  }
}
