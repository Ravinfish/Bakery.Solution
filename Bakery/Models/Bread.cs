// using System.ComponentModel.DataAnnotations;
// using System.Security.Cryptography.X509Certificates;

namespace Bakery.Models
{

  public class Bread
  {
    public int Order { get; set; }
    public Bread(int quantity)
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
        if (Order % 3 == 0)
        {
          int dealOrder = Order - (Order /  3);
          int breadTotalCost = dealOrder * 5;
          return breadTotalCost;
        }
        else
        {
          return Order * 5;
        }
      }
    }
    public void UpdateOrder(int addToOrder)
    {
      Order = Order + addToOrder;
    }
  }

}


