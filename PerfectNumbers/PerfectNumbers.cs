using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumbers
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter a number");
      Int16 number = 0;
      while (number != 1)
      {
        number = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(checkPerfectNumber(number));
        Console.WriteLine("Enter a number");
      }

      //if(checkPerfectNumber(278))

    }

    private static bool checkPerfectNumber(int n)
    {
      int sum = 0;
      for (int i =1 ; i < n; ++i)
      {
        if (n % i == 0)
        {
          sum += i;
        }
      }
      return sum == n;

//      def perfect_number(n):  
//02.    sum = 0  
//03.    for x in range(1, n):  
//04.        if n % x == 0:  
//05.            sum += x  
//06.    return sum == n  
//07.print(perfect_number(6)) 

    }
  }
}
