using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
  class Program
  {
    static void Main(string[] args)
    {

      for (int i = 0; i < 10; ++i)
      {
        Console.WriteLine(CalculateFibonacci(i));
      }
    }

    private static int CalculateFibonacci(int step)
    {
      int a = 0;
      int b = 1;
      int temp = 0;
      for(int fibindex = 0; fibindex<step; ++fibindex)
      {
        temp = a;
        a = b;
        b = b + temp;
      }
      return a;
    }//end method
  }
}
