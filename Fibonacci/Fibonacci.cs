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

      for (int i = 0; i < 10; ++i )
      {
        Console.WriteLine(CalculateFibonacci(i));
      }
    }

    private static int CalculateFibonacci(int step)
    {
      int a = 0;
      int b = 1;
      for (int x = 0; x < step; ++x )
      {
        int temp = a;
        a = b;
        b = temp + b;
      }
      return a;
    }
  }
}
