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
      Console.WriteLine("Enter number to check");
      long numbertocheck = Convert.ToInt64(Console.ReadLine());
      Console.WriteLine("Enter lower bound");
      long lowerbound = Convert.ToInt64(Console.ReadLine());
      Console.WriteLine("Enter the upper bound");
      long upperBound = Convert.ToInt64(Console.ReadLine());
      String result = checknumberiswithinRange(numbertocheck, lowerbound, upperBound).ToString();
      Console.WriteLine("{0} the number is in the range", checknumberiswithinRange(numbertocheck, lowerbound, upperBound).ToString());

      //Console.WriteLine("{0} the number is in the range", useEnumerableToCheck(numbertocheck, lowerbound, upperBound).ToString());
    }

    private static Boolean checknumberiswithinRange(long number, long lower, long upper)
    {
      if (number >= lower && number <= upper)
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
