
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMinNumbersInARange
{
  class Program
  {
    static void Main(string[] args)
    {
    }


    public static void maximumGap(int theNumber)
    {
      string gap = Convert.ToString(theNumber, 2);
      string newGap = "";
      int count = 0;
      int n = 0;
      List<int> mylist = new List<int>();
      for (int i = 0; i < gap.Length - 1; ++i)
      {
        if ((gap[i] == '1') && (gap[i + 1] == '0'))
        {
          newGap = gap.Substring(i + 1, gap.Length - (i + 1));

          while (n < newGap.IndexOf('1'))
          {
            ++count;
            ++n;
          }
        }
      }

      Console.WriteLine(newGap + " ");
      mylist.Add(count);
      count = 0;
      newGap = "";

      mylist.Sort();
      mylist.Reverse();
      Console.Write(mylist[0].ToString() + "  ");
    }
  }
}