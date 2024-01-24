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
  }
}