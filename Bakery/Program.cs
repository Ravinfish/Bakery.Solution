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
      Console.WriteLine("Here is our menu: \n* Bread: $5 per loaf \n* Pastries: $2 each");
      Console.WriteLine("");
      Console.WriteLine("Today's special: \n* Bread: Buy 2, get one FREE! \n* Pastries: Buy 3, get one FREE!");
      PlaceOrder();
    }
    static void PlaceOrder()
    {
      Console.WriteLine("");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("");
      Console.WriteLine("How many loaves of bread would you like? Please enter a number...");
      string loafQuantity = Console.ReadLine();
      Console.WriteLine("How many pastries would you like? Please enter a number...");
      string pastryQuantity = Console.ReadLine();
      int loafQuantityInt = int.Parse(loafQuantity);
      int pastryQuantityInt = int.Parse(pastryQuantity);
      Bread newBread = new Bread(loafQuantityInt);
      Pastry newPastry = new  Pastry(pastryQuantityInt);
      ConfirmOrder(newBread, newPastry);
    }
    static void ConfirmOrder(Bread newBread, Pastry newPastry)
    {
      Console.WriteLine("");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("");
      Console.WriteLine($"I see you would like to order: \n*{newBread.Order} loaves of bread \n*{newPastry.Order} pastries");
      Console.WriteLine("");
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
      Console.WriteLine("");
      Console.WriteLine("Does your order look correct? Enter 'Y' to recieve your total cost or 'N' to update your order");
      string userInput = Console.ReadLine();
      if (userInput == "Y"  || userInput =="y")
      {
        GetTotal(newBread, newPastry);
      }
      else{
        Console.WriteLine("");
        Console.WriteLine("Update order");
        PlaceOrder();
      }
    }
    static void GetTotal(Bread newBread, Pastry newPastry)
    {
      int breadTotal = newBread.CalcPrice();
      int pastryTotal = newPastry.CalcPrice();
      Console.WriteLine("");
      Console.WriteLine("Here is your reciept:");
      Console.WriteLine("");
      Console.WriteLine($"Bread: {newBread.Order} loaves: ${breadTotal}");
      Console.WriteLine($"Pastry: {newPastry.Order} pastries: ${pastryTotal}");
      Console.WriteLine("Total amount is: $" + (breadTotal + pastryTotal));
      Console.WriteLine("");
  
    }
  }
}