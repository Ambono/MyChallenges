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
      Console.WriteLine(listOfSquares(limit));
      Console.ReadKey();
    }
    public static string listOfSquares(int limit)
    {
    List<int> l= new List<int>();
    for (int i = 1; i < limit; ++i)
    {
      l.Add(i * i);
    }
       String listelement = "";
    foreach (int numbers in l)
    {
      listelement +=numbers + " ";
    }
return listelement;
    }

  }
}
