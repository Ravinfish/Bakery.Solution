using System;
using Bakery.Models;

namespace Bakery
{
  class Program
  {
    static void Main()
    {
      Console.BackgroundColor = ConsoleColor.Magenta;
      Console.Clear();
      Console.WriteLine(Bakery.UserInterfaceModels.WelcomeBanner.Welcome);
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("Welcome to Roll & Rise Bakery!");
    }
  }
}