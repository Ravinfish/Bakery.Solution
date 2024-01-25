using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryOrder_ReturnPastryOrder_Int()
    {
      int newOrder = 1;
      Pastry newPastry = new Pastry(newOrder);
      int result = newPastry.Order;
      Assert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void SetPastryOrder_SetsValueOfOrder_Void()
    {
      int newOrder = 1;
      Pastry newPastry = new Pastry(1);
      newPastry.Order = newOrder;
      Assert.AreEqual(newOrder, newPastry.Order);
    }

    [TestMethod]
    public void  CalcPrice_DeterminesPriceByOrderLessThanOne_Int()
    {
    Pastry noOrder = new Pastry(0);
    int PastryOrder = noOrder.CalcPrice();
    Assert.AreEqual(0, PastryOrder);
    }

    [TestMethod]
    public void CalcPrice_DeterminesPriceOfOrderOfOne_Int()
    {
      Pastry newOrder = new Pastry(1);
      int pastryOrder = newOrder.CalcPrice();
      Assert.AreEqual(2, pastryOrder);
    }

    [TestMethod]
    public void CalcPrice_DeterminesPriceByOrderOfFour_Int()
    {
      Pastry newOrder = new Pastry(4);
      int pastryOrder = newOrder.CalcPrice();
      Assert.AreEqual(6, pastryOrder);
    }

  }
}