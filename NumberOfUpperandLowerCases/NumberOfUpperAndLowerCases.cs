using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOfUpperAndLowerCases
{
  class Program
  {
    static void Main(string[] args)
    {
      calculateNumberOfUpperAndLowerCases("The Quick Brown Fox Jumped Over the Lazy Sheeps");
    }
    private static void calculateNumberOfUpperAndLowerCases(String str)
    {
      int lowercount = 0;
      int uppercount = 0;

      for (int i = 0; i < str.Length; ++i)
      {
        if(char.IsUpper(str[i]))
          
          uppercount++;
        else
          lowercount++;
      }
        Console.WriteLine("The number of lower cases {0}. The number of upper cases is {1}", lowercount, uppercount);      
      
    }
  }
}
