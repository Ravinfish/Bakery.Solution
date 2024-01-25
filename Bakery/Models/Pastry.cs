using System.Security.Cryptography.X509Certificates;

namespace Bakery.Models
{

  public class Pastry
  {
    public int Order { get; set; }
    public Pastry(int quantity)
    {
      Order = quantity;
    }

    public int CalcPrice()
    {
      if (Order < 1)
      {
        return 0;
      }
      else
      {
        if (Order % 4 == 0)
        {
          int dealOrder = (Order - (Order /  4));
          int breadTotalCost = dealOrder * 2;
          return breadTotalCost;
        }
        else
        {
          return Order * 2;
        }
      }
    }
  }

}
