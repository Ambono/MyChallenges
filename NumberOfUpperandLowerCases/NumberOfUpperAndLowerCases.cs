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
      calculateNumberOfUpperAndLowerCases("The Quick Brown Fox Jumped Over The Lazy Sheeps");
    }
    private static void calculateNumberOfUpperAndLowerCases(String str)
    {
      int lowercase = 0;
      int uppercase = 0;

      for (int caseTypecount = 0; caseTypecount < str.Length; ++caseTypecount)
      {
        if(char.IsLower(str[caseTypecount]))
        {
          ++lowercase;
        }
        else if (char.IsUpper(str[caseTypecount]))
        {
          ++uppercase;
        }
      }

      Console.WriteLine("{0, 5}  {1, 10}", "Lower" ," Upper");
      Console.WriteLine("{0, 5} {1, 10}", lowercase, uppercase);
    } //end method
  }
}
