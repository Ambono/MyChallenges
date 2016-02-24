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
      Console.Write("enter a number: ");
      int number = Convert.ToInt32(Console.ReadLine());
      long factorial = CalculateFactorialRecursive(number);
      Console.WriteLine("Factorial of {0} is {1}", number, factorial);
      Console.ReadKey();
    }
    private static long CalculateFactorialRecursive(int number)
    {
      return (number == 0) ? 1 : CalculateFactorialRecursive(number - 1) * number;
    
    }

  }
}
