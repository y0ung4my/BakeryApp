using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Int()
    {
      Pastry newPastry = new Pastry(5);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
    [TestMethod]
    public void BuyTwoGetOneHalfSaleMethod_CalculatesSalePrice_2()
    {
      Pastry newPastry = new Pastry(2);
      int pastries = 1;
      Assert.AreEqual(2, newPastry.BuyTwoGetOneHalfSale(pastries));
    }
    [TestMethod]
    public void BuyTwoGetOneHalfSaleMethod_CalculatesSalePrice_5()
    {
      Pastry newPastry = new Pastry(2);
      int pastries = 3;
      Assert.AreEqual(5, newPastry.BuyTwoGetOneHalfSale(pastries));
    }
  }
}