using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfSquares
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter number:");
      int limit = Convert.ToInt32(Console.ReadLine());
      //Console.WriteLine(listOfSquares(limit));
     listOfSquares(limit);
      Console.ReadKey();
    }

      /// <summary>
      /// Calculates and didplays a list of the squares of number infrior to the number entered
      /// </summary>
      /// <param name="limit"></param>   
   
    public static void listOfSquares(int limit)
    {
        for (int i = 1; i < limit; ++i)
        {
            Console.WriteLine(i * i);
            Console.WriteLine();
        }
    }

  }
}
