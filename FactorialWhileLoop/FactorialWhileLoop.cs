using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialWhileLoop
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(calculatefactorial(3));
      Console.ReadKey();
    }

    private static int calculatefactorial(int number)
    {
      int i =1;
      int factorial = number;
      while (number>1)
      {
        factorial *= --number;
      }
      return factorial;
    }
  }
}
