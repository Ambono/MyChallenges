using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralContainer
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] C = { 1, 3, 7, 11, 5 };
      Console.WriteLine("{0}", findLargerPerimeter(C));
    }
       
      /// <summary>
      /// Given that a<p<q by requirement.
      /// </summary>
      /// <param name="A"></param>
      /// <returns></returns>
    private static int findLargerPerimeter(int[] A)
    {
      List<int> b = new List<int>();
      for (int p = 0; p < A.Length; ++p)
      {
        for (int q = 0; q < A.Length; ++q)
        {
          for (int r = 0; r < A.Length; ++r)
          {
            if ((p < q) && (q < r))
            {
              if ((A[p] + A[q] > A[r]) && (A[q] + A[r] > A[p]) && (A[r] + A[p] > A[q]))
              {
                b.Add(A[p] + A[q] + A[r]);
              }

            }
          }

        }

      }

      var newb = from value in b
                 orderby value
                 select value;
      return newb.Any() ? newb.First() : -1;     
    }
  }
}
