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
        int breadDeal = Order / 3;
        int breadTotalCost = (Order - breadDeal) * 5;
        return breadTotalCost;
      
      }
    }
    public void UpdateOrder(int addToOrder)
    {
      Order += addToOrder;
    }
  }

}


