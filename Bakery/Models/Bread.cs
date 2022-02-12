using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int BreadCost { get; set; }

    public Bread(int breadCost)
    {
      BreadCost = breadCost;
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


