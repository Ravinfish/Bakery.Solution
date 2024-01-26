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
        int pastryDeal = Order / 4;
        int pastryTotalCost = (Order - pastryDeal) * 2;
        return pastryTotalCost;
      }
    }
    public void UpdateOrder(int addToOrder)
    {
      Order += addToOrder;
    }
  }

}
