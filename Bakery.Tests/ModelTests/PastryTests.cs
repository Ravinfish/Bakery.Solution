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
      int newOrder = 2;
      Pastry newPastry = new Pastry(2);
      newPastry.Order = newOrder;
      Assert.AreEqual(newOrder, newPastry.Order);
    }

  }
}