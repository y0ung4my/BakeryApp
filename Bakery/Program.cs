using System;
using Bakery.Models;

namespace Bakery {
  class Program
  {
    static void Main()
    {
      //SET PRICES HERE:
      int breadPrice = 5;
      int pastryPrice = 2;

      Bread newBread = new Bread(breadPrice);
      Pastry newPastry = new Pastry(pastryPrice);

      Console.WriteLine("Welcome to the Bakery Sale!");
      Console.WriteLine("How many loaves would you like? Each third loaf is free!");
      int loaves = Convert.ToInt16(Console.ReadLine());

      Console.WriteLine("How many pastries would you like? Each third pastry is a dollar off!");
      int pastries = Convert.ToInt16(Console.ReadLine());

      int breadSale = newBread.BuyTwoGetOneSale(loaves);
      int pastrySale = newPastry.BuyTwoGetOneHalfSale(pastries);
      int totalSale = breadSale + pastrySale;

      Console.WriteLine("The total for your order is $" + totalSale);

    }

  }
}

