using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfItem_Int()
    {
      Bread newBread = new Bread(5);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void BuyTwoGetOneSaleMethod_CalculatesSalePrice_10()
    {
      Bread newBread = new Bread(5);
      int loaves = 3;
      Assert.AreEqual(10, newBread.BuyTwoGetOneSale(loaves));
    }
    [TestMethod]
    public void BuyTwoGetOneSaleMethod_CalculatesSalePrice_15()
    {
      Bread newBread = new Bread(5);
      int loaves = 4;
      Assert.AreEqual(15, newBread.BuyTwoGetOneSale(loaves));
    }
  }
}