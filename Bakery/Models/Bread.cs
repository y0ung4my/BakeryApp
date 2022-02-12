using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost;

    public Bread(int inputtedBreadCost)
    {
      BreadCost = inputtedBreadCost;
    }
        public int BuyTwoGetOneSale(int numberOfLoaves)
    {
      int finalBreadCost = 0;
      for (int i = 1; i <= numberOfLoaves; i++) 
      {
        if ( i % 3 != 0 )
        {
          finalBreadCost += BreadCost;
        }
      }
      return finalBreadCost;
    }
  }
}


