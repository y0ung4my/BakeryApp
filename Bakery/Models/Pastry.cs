using System;

namespace Bakery.Models
{
  public class Pastry
  {
    public int PastryCost;

    public Pastry(int inputtedPastryCost)
    {
      PastryCost = inputtedPastryCost;
    }
        public int BuyTwoGetOneHalfSale(int numberOfPastries)
    {
      int finalPastryCost = 0;
      for (int i = 1; i <= numberOfPastries; i++) 
      {
        if ( i % 3 != 0 )
        {
          finalPastryCost += PastryCost;
        }
        else
        {
          finalPastryCost += (PastryCost -1);
        }
      }
      return finalPastryCost;
    }
  }
}


