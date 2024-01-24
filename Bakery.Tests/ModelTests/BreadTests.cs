using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadOrder_ReturnBreadOrder_Int()
    {
      int newOrder = 1;
      Bread newBread = new Bread(newOrder);
      int result = newBread.Order;
      Assert.AreEqual(newOrder, result);
    }

    [TestMethod]
    public void SetBreadOrder_SetsValueofOrder_Void()
    {
      int newOrder = 3;
      Bread newBread = new Bread(1);
      newBread.Order = newOrder;
      Assert.AreEqual(newOrder, newBread.Order);
    }

    [TestMethod]
    public void  CalPrice_DeterminesPriceByOrderLessThanOne_Int()
    {
    Bread noOrder = new Bread(0);
    int BreadOrder = noOrder.CalcPrice();
    Assert.AreEqual(0, BreadOrder);
    }

    [TestMethod]
    public void CalcPrice_DeterminesPriceByOrderOverOne_Int()
    {
      Bread newOrder = new Bread(1);
      int breadOrder = newOrder.CalcPrice();
      Assert.AreEqual(5, breadOrder);
    }

    [TestMethod]
    public void CalcPrice_DeterminesPriceByOrderOfThree_Int()
    {
      Bread newOrder = new Bread(3);
      int breadOrder = newOrder.CalcPrice();
      Assert.AreEqual(10, breadOrder);
    }
  }
}