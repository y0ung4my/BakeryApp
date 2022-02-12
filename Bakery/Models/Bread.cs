
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
      int finalCost = 0;
      for (int i = 0; i <= numberOfLoaves; i++) 
      {
        if ( i % 3 != 0 )
        {
          finalCost += BreadCost;
        }
      }
      return finalCost;
    }
  }
}


