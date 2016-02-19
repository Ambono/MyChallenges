using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialRecursive
{
  class FactorialRecursive
  {
    static void Main(string[] args)
    {
      Console.WriteLine("enter a number");
      int number = Convert.ToInt32(Console.ReadLine());
      long factorial = CalculateFactorial(number);
      Console.WriteLine("{0}Factorial of number is {1}", number, factorial);
      Console.ReadKey();
    }
    private static long CalculateFactorial(int number)
    {
      if (number == 1)
        return 1;
      return number *  CalculateFactorial  (number - 1);
    }

  }
}
