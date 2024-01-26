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
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("");
      Console.WriteLine("Welcome to Roll & Rise Bakery!");
      Console.WriteLine("");
      Console.WriteLine("Here is the menu: \n* Bread: $5 per loaf \n* Pastries: $2 each");
      Console.WriteLine("");
      Console.WriteLine("Today's special: \n* Bread: Buy 2, get one FREE! \n* Pastries: Buy 3, get one FREE!");
      // PlaceOrder();
    }
  }
}