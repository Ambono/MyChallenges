using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckANumberIsInRange
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Enter lower bound: ");
      int lower = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the upper bound: ");
      int upper = Convert.ToInt32(Console.ReadLine());
      Console.Write("Enter the number in bound: ");
      int number = Convert.ToInt32(Console.ReadLine());     
      Console.WriteLine(checknumberiswithinRange( number, lower,  upper));
      Console.ReadKey();      
    }

    private static Boolean checknumberiswithinRange(long number, long lower, long upper)
    {
      if(number<=upper && number>=lower)
      {
        return true;
      }
      return false;
    }

    private static Boolean useEnumerableToCheck(int x, int l, int u)
    {
      if (Enumerable.Range(l, u).Contains(x))
      {
        return true;
      }
      return false;   
    }
  }
}
