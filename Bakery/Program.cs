using System;
using System.Runtime.CompilerServices;
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
      PlaceOrder();
    }
    static void PlaceOrder()
    {
      Console.WriteLine("");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("How many loaves of bread would you like? Please enter a number...");
      string loafQuantity = Console.ReadLine();
      Console.WriteLine("How many pastries would you like? Please enter a number...");
      string pastryQuantity = Console.ReadLine();
      int loafQuantityInt = int.Parse(loafQuantity);
      int pastryQuantityInt = int.Parse(pastryQuantity);
      Bread newBread = new Bread(loafQuantityInt);
      Pastry newPastry = new  Pastry(pastryQuantityInt);
      // ConfirmOrder(newBread, newPastry);
    }
  }
}